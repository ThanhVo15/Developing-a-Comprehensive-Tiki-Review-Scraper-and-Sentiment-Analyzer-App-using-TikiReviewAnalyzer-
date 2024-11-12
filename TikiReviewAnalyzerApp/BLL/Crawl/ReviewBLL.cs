using System.Collections.Generic;
using DTO;
using DAL;

namespace BLL
{
    public class ReviewBLL
    {
        private readonly ReviewDAL _reviewDAL;

        public ReviewBLL()
        {
            _reviewDAL = new ReviewDAL();
        }

        public void SaveReviews(List<ReviewDTO> reviews)
        {
            foreach (var review in reviews)
            {
                if (!_reviewDAL.CheckDuplicateReview(review.ReviewID))
                {
                    _reviewDAL.InsertReview(review);
                }
            }
        }
    }
}
