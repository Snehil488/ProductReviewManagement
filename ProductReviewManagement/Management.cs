using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductReviewManagement
{
    class Management
    {
        public void TopThreeRecords(List<ProductReview> listProductReview)
        {
            var recordedData = (from reviews in listProductReview
                                orderby reviews.Rating descending
                                select reviews).Take(3);
            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductID:- " + list.ProductID + " " + "UserID:- " + list.UserID
                    + " " + "Rating:- " + list.Rating + " " + "Review:- " + list.Review + " " + "isLike:- " + list.IsLike);
            }
        }
    }
}
