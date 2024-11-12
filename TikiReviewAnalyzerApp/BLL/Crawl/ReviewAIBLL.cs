using DAL;
using DTO;

namespace BLL
{
    public class ReviewAIBLL
    {
        private readonly ReviewAIDAL _reviewAIDAL;

        public ReviewAIBLL()
        {
            _reviewAIDAL = new ReviewAIDAL();
        }

        public int SaveReviewCate(ReviewGPTCateDTO reviewCate)
        {
            return _reviewAIDAL.InsertReviewCate(reviewCate);
        }

        public void SaveReview(ReviewGPTDTO review)
        {
            _reviewAIDAL.InsertReview(review);
        }
    }
}
