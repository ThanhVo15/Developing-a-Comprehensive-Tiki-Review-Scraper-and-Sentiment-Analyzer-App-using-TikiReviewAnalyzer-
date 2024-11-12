using DAL.Train_Model;
using DTO.TrainModel;
using Microsoft.ML.Data;
using Microsoft.ML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BLL.Train_Model
{
    public class ProcessedCommentResult
    {
        public string Comment { get; set; }
        public int Sentiment { get; set; } // 0 hoặc 1
        public string Content { get; set; } // "Product" hoặc "Service"
    }
    public class Preprocessing
    {
        public static string PreprocessComment(string comment)
        {
            // Lấy danh sách từ dừng từ cơ sở dữ liệu
            StopWordAccess swbll = new StopWordAccess();
            List<StopWordData> dsSW = swbll.LayStopWords();
            HashSet<string> stopWordsSet = new HashSet<string>(dsSW.Select(sw => sw.stop_words.ToLower()));

            // 1. Chuyển bình luận thành chữ thường
            comment = comment.ToLower();

            // 2. Loại bỏ các ký tự đặc biệt
            comment = Regex.Replace(comment, @"[^\w\s]", "");

            // 3. Tách từ và loại bỏ stop words
            var words = comment.Split(' ')
                               .Where(word => !stopWordsSet.Contains(word))
                               .ToArray();

            // 4. Ghép lại thành chuỗi sau khi loại bỏ stop words
            return string.Join(" ", words);

            /* Cách sử dụng hàm này:
             CommentAccess cmtbll = new CommentAccess();
            List<CommentData> dsCmt = cmtbll.LayToanBoTikiComment();

            foreach (var commentData in dsCmt)
            {
                string processedComment = Preprocessing.PreprocessComment(commentData.cmt);
                Console.WriteLine($"Original: {commentData.cmt}");
                Console.WriteLine($"Processed: {processedComment}");
            }*/
        }
        public static (List<ProcessedCommentResult> results, ITransformer model) ClassifyComments(List<CommentData> comments, string sampleComment, Action<int> progressCallback)
        {
            MLContext mlContext = new MLContext();

            var preprocessedComments = comments.Select(c => new CommentData { cmt = PreprocessComment(c.cmt) }).ToList();
            IDataView dataView = mlContext.Data.LoadFromEnumerable(preprocessedComments);

            var pipeline = mlContext.Transforms.Text.FeaturizeText("Features", nameof(CommentData.cmt))
                            .Append(mlContext.Clustering.Trainers.KMeans("Features", numberOfClusters: 2));

            var model = pipeline.Fit(dataView);

            var transformedData = model.Transform(dataView);
            var predictions = mlContext.Data.CreateEnumerable<CommentPrediction>(transformedData, reuseRowObject: false).ToList();

            string preprocessedSampleComment = PreprocessComment(sampleComment);
            var sampleData = new List<CommentData> { new CommentData { cmt = preprocessedSampleComment } };
            var sampleDataView = mlContext.Data.LoadFromEnumerable(sampleData);
            var sampleTransformedData = model.Transform(sampleDataView);
            var samplePrediction = mlContext.Data.CreateEnumerable<CommentPrediction>(sampleTransformedData, reuseRowObject: false).First();

            string labelForCluster0 = samplePrediction.PredictedClusterId == 1 ? "Product" : "Service";
            string labelForCluster1 = samplePrediction.PredictedClusterId == 1 ? "Service" : "Product";

            List<ProcessedCommentResult> results = new List<ProcessedCommentResult>();
            for (int i = 0; i < comments.Count; i++)
            {
                string label = predictions[i].PredictedClusterId == 1 ? labelForCluster1 : labelForCluster0;
                results.Add(new ProcessedCommentResult
                {
                    Comment = comments[i].cmt,
                    Sentiment = predictions[i].PredictedClusterId == 1 ? 1 : 0, // Giữ nguyên giá trị 0 hoặc 1 cho Sentiment
                    Content = label // "Product" hoặc "Service"
                });

                progressCallback?.Invoke(i + 1);
            }

            return (results, model);
        }
    }

    public class CommentPrediction
    {
        [ColumnName("PredictedLabel")]
        public uint PredictedClusterId { get; set; }
        public float[] Score { get; set; }
    }
}
