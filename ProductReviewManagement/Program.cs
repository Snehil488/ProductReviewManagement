using System;
using System.Collections.Generic;

namespace ProductReviewManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Product Review Management");
            List<ProductReview> productReviewList = new List<ProductReview>()
            {
                new ProductReview(){ProducID=1,UserID=1,Rating=2,Review="Good",IsLike=true},
                new ProductReview(){ProducID=2,UserID=1,Rating=4,Review="Good",IsLike=true},
                new ProductReview(){ProducID=3,UserID=1,Rating=5,Review="Good",IsLike=true},
                new ProductReview(){ProducID=4,UserID=1,Rating=6,Review="Good",IsLike=false},
                new ProductReview(){ProducID=5,UserID=1,Rating=2,Review="nice",IsLike=true},
                new ProductReview(){ProducID=6,UserID=1,Rating=1,Review="bad",IsLike=true},
                new ProductReview(){ProducID=8,UserID=1,Rating=1,Review="Good",IsLike=false},
                new ProductReview(){ProducID=8,UserID=1,Rating=9,Review="nice",IsLike=true},
                new ProductReview(){ProducID=2,UserID=1,Rating=10,Review="nice",IsLike=true},
                new ProductReview(){ProducID=10,UserID=1,Rating=8,Review="nice",IsLike=true},
                new ProductReview(){ProducID=11,UserID=1,Rating=3,Review="nice",IsLike=true}
            };
        }
    }
}
