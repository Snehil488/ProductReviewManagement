﻿using System;
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
        public void SelectedRecords(List<ProductReview> listProductReview)
        {
            var selectedRecords = (from reviews in listProductReview
                                   where (reviews.ProductID == 1 || reviews.ProductID == 4 || reviews.ProductID == 9)
                                   && reviews.Rating > 3
                                   select reviews);
            foreach (var list in selectedRecords)
            {
                Console.WriteLine("ProductID:- " + list.ProductID + " " + "UserID:- " + list.UserID
                    + " " + "Rating:- " + list.Rating + " " + "Review:- " + list.Review + " " + "isLike:- " + list.IsLike);
            }
        }
    }
}
