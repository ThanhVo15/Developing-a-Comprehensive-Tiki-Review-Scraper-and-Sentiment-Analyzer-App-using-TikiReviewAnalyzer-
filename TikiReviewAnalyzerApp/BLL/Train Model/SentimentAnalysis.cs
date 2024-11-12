using Microsoft.ML.Data;
using Microsoft.ML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Train_Model
{
    public class SentimentAnalysis
    {
        public class SentimentData
        {
            public string Text { get; set; }
            public bool Label { get; set; }
        }

        public class SentimentPrediction : SentimentData
        {
            [ColumnName("PredictedLabel")]
            public bool Prediction { get; set; }

            public float Probability { get; set; }
            public float Score { get; set; }
        }

        public static (ITransformer model, double accuracy, double precision, double recall, double f1Score) TrainAndEvaluateSentimentModel(List<SentimentData> data, float trainRatio)
        {
            MLContext mlContext = new MLContext();

            // Chia dữ liệu thành train và test dựa trên tỷ lệ trainRatio
            var trainData = data.Take((int)(data.Count * trainRatio)).ToList();
            var testData = data.Skip((int)(data.Count * trainRatio)).ToList();

            IDataView trainDataView = mlContext.Data.LoadFromEnumerable(trainData);
            IDataView testDataView = mlContext.Data.LoadFromEnumerable(testData);

            // Tạo pipeline cho sentiment analysis
            var pipeline = mlContext.Transforms.Text.FeaturizeText("Features", nameof(SentimentData.Text))
                .Append(mlContext.BinaryClassification.Trainers.SdcaLogisticRegression(labelColumnName: nameof(SentimentData.Label), featureColumnName: "Features"));

            // Huấn luyện mô hình
            var model = pipeline.Fit(trainDataView);

            // Dự đoán trên test data
            var predictions = model.Transform(testDataView);
            var metrics = mlContext.BinaryClassification.Evaluate(predictions, nameof(SentimentData.Label));

            double accuracy = metrics.Accuracy;
            double precision = metrics.PositivePrecision;
            double recall = metrics.PositiveRecall;
            double f1Score = metrics.F1Score;

            return (model, accuracy, precision, recall, f1Score);
        }
    }
}
