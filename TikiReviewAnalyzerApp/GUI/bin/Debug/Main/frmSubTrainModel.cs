using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.ML;
using System.Text;
using System.Windows.Forms;
using BLL.Train_Model;
using DAL.Train_Model;
using DTO.TrainModel;


namespace GUI
{
    public partial class frmSubTrainModel : Form
    {
        private ITransformer trainedModel;
        public frmSubTrainModel()
        {
            InitializeComponent();
            lblProgressPercentage.BackColor = Color.Transparent;
            lblProgressPercentage.ForeColor = Color.Orange;
        }

        private void frmSubTrainModel_Load(object sender, EventArgs e)
        {
            CommentAccess cmtbll = new CommentAccess();
            List<CommentData> dsCmt = cmtbll.LayToanBoTikiComment();
            pictureBoxNeg.Visible = false;
            pictureBoxPos.Visible = false;
            lvCmt.Items.Clear();
            foreach (CommentData sp in dsCmt)
            {
                ListViewItem lvi = new ListViewItem(sp.stt + "");
                lvi.SubItems.Add(sp.cmt);
                lvi.SubItems.Add(sp.label + "");

                lvCmt.Items.Add(lvi);
            }
        }

        private void btnTrainSentiment_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu txtTrainRate có giá trị hợp lệ
            if (!float.TryParse(txtTrainRate.Text, out float trainRate) || trainRate <= 0 || trainRate >= 1)
            {
                MessageBox.Show("Please enter a valid train rate between 0 and 1.", "Invalid Train Rate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy dữ liệu từ database (giả sử đã phân loại thành 0 và 1 cho sentiment)
            CommentAccess cmtbll = new CommentAccess();
            List<CommentData> dsCmt = cmtbll.LayToanBoTikiComment();

            // Kiểm tra dữ liệu không trống
            if (dsCmt == null || dsCmt.Count == 0)
            {
                MessageBox.Show("No data available for training.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Chuyển đổi dữ liệu thành định dạng cần thiết cho sentiment analysis
            var sentimentData = dsCmt.Select(c => new SentimentAnalysis.SentimentData
            {
                Text = c.cmt,
                Label = c.label == 1 // giả sử c.label là 0 hoặc 1 cho sentiment
            }).ToList();

            // Tính toán số lượng dữ liệu huấn luyện và đánh giá dựa trên tỷ lệ trainRate
            int trainCount = (int)(sentimentData.Count * trainRate);
            var trainData = sentimentData.Take(trainCount).ToList();
            var testData = sentimentData.Skip(trainCount).ToList();

            MLContext mlContext = new MLContext();
            IDataView trainDataView = mlContext.Data.LoadFromEnumerable(trainData);
            IDataView testDataView = mlContext.Data.LoadFromEnumerable(testData);

            // Tạo pipeline cho sentiment analysis
            var pipeline = mlContext.Transforms.Text.FeaturizeText("Features", nameof(SentimentAnalysis.SentimentData.Text))
                            .Append(mlContext.BinaryClassification.Trainers.SdcaLogisticRegression(labelColumnName: nameof(SentimentAnalysis.SentimentData.Label), featureColumnName: "Features"));

            // Huấn luyện mô hình và gán vào biến trainedModel
            trainedModel = pipeline.Fit(trainDataView);

            // Đánh giá mô hình trên tập test
            var predictions = trainedModel.Transform(testDataView);
            var metrics = mlContext.BinaryClassification.Evaluate(predictions, nameof(SentimentAnalysis.SentimentData.Label));

            // Hiển thị kết quả lên các textbox
            txtAcc.Text = metrics.Accuracy.ToString("P2");
            txtPre.Text = metrics.PositivePrecision.ToString("P2");
            txtRecall.Text = metrics.PositiveRecall.ToString("P2");
            txtF1.Text = metrics.F1Score.ToString("P2");

            MessageBox.Show("Sentiment Model Trained and Evaluated Successfully!", "Training Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void btnTrain_Click(object sender, EventArgs e)
        {
            CommentAccess cmtbll = new CommentAccess();
            List<CommentData> dsCmt = cmtbll.LayToanBoTikiComment();

            progressBarTrainAndCluster.Value = 0;
            progressBarTrainAndCluster.Maximum = dsCmt.Count;
            lblProgressPercentage.Text = "0%";
            lblProgressPercentage.BackColor = Color.Transparent;

            string sampleComment = "sách bị méo và nát";

            var (results, model) = await Task.Run(() => Preprocessing.ClassifyComments(dsCmt, sampleComment, progress =>
            {
                Invoke(new Action(() =>
                {
                    progressBarTrainAndCluster.Value = progress;
                    int percentComplete = (int)((double)progress / dsCmt.Count * 100);
                    lblProgressPercentage.Text = percentComplete + "%";

                    if (percentComplete >= 90)
                    {
                        lblProgressPercentage.BackColor = lblProgressPercentage.BackColor == Color.Orange ? Color.Red : Color.Orange;
                    }
                    else
                    {
                        lblProgressPercentage.BackColor = Color.Transparent;
                    }
                }));
            }));

            trainedModel = model;

            lvCmt.Items.Clear();

            int index = 1;
            foreach (var result in results)
            {
                ListViewItem lvi = new ListViewItem(index.ToString());
                lvi.SubItems.Add(result.Comment);      // Cột Comments
                lvi.SubItems.Add(result.Sentiment.ToString()); // Cột Sentiment giữ nguyên giá trị 0 hoặc 1
                lvi.SubItems.Add(result.Content);      // Cột Content ("Product" hoặc "Service")

                lvCmt.Items.Add(lvi);
                index++;
            }

            progressBarTrainAndCluster.Value = progressBarTrainAndCluster.Maximum;
            lblProgressPercentage.Text = "100%";
            lblProgressPercentage.BackColor = Color.Transparent;

            int productCount = results.Count(r => r.Content == "Product");
            int serviceCount = results.Count(r => r.Content == "Service");

            lblNumPrdCmt.Text = productCount + "";
            lblNumSerCmt.Text = serviceCount + "";

            MessageBox.Show("Clustering Completed!", "Process Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSaveModel_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu chưa nhập tên model
            if (string.IsNullOrWhiteSpace(txtModelName.Text))
            {
                MessageBox.Show("Please enter a model name before saving.", "Save Model", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (trainedModel != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "ZIP files (*.zip)|*.zip",
                    Title = "Save Trained Model",
                    FileName = txtModelName.Text + ".zip" // Sử dụng tên từ txtModelName
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    MLContext mlContext = new MLContext();
                    mlContext.Model.Save(trainedModel, null, saveFileDialog.FileName);

                    MessageBox.Show("Model saved successfully!", "Save Model", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("No model has been trained yet!", "Save Model", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSentimentAnalize_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu chưa có mô hình đã huấn luyện
            if (trainedModel == null)
            {
                MessageBox.Show("Please train the sentiment model first.", "Model Not Trained", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra nếu txtTestSentiment trống
            if (string.IsNullOrWhiteSpace(txtTestSentiment.Text))
            {
                MessageBox.Show("Please enter text to analyze.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Chuẩn bị dữ liệu cần đánh giá
            var mlContext = new MLContext();
            var singleComment = new List<SentimentAnalysis.SentimentData>
        {
            new SentimentAnalysis.SentimentData { Text = txtTestSentiment.Text }
        };
            IDataView dataView = mlContext.Data.LoadFromEnumerable(singleComment);

            // Dự đoán sentiment
            var predictions = trainedModel.Transform(dataView);
            var predictedResults = mlContext.Data.CreateEnumerable<SentimentAnalysis.SentimentPrediction>(predictions, reuseRowObject: false).FirstOrDefault();

            if (predictedResults != null)
            {
                // Hiển thị phần trăm xác suất Positive và Negative
                lblPercentPos.Text = (predictedResults.Probability * 100).ToString("F2") + "%";
                lblPercentNeg.Text = ((1 - predictedResults.Probability) * 100).ToString("F2") + "%";

                // Đánh dấu checkbox dựa trên phần trăm lớn hơn
                if (predictedResults.Prediction) // Positive sentiment
                {
                    checkboxPositive.Checked = true;
                    checkboxNegative.Checked = false;
                    pictureBoxPos.Visible = true;
                    pictureBoxNeg.Visible = false;
                }
                else // Negative sentiment
                {
                    checkboxPositive.Checked = false;
                    checkboxNegative.Checked = true;
                    pictureBoxPos.Visible = false;
                    pictureBoxNeg.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Failed to analyze sentiment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveModelSentiment_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu chưa nhập tên model
            if (string.IsNullOrWhiteSpace(txtSentimentModelName.Text))
            {
                MessageBox.Show("Please enter a model name before saving.", "Save Model", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra nếu mô hình đã được huấn luyện
            if (trainedModel != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "ZIP files (*.zip)|*.zip",
                    Title = "Save Trained Sentiment Model",
                    FileName = txtSentimentModelName.Text + ".zip" // Sử dụng tên từ txtSentimentModelName
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    MLContext mlContext = new MLContext();
                    mlContext.Model.Save(trainedModel, null, saveFileDialog.FileName);

                    MessageBox.Show("Sentiment model saved successfully!", "Save Model", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("No model has been trained yet!", "Save Model", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
