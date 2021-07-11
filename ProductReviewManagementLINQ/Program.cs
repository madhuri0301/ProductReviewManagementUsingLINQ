using System;
using System.Collections.Generic;

namespace ProductReviewManagementLINQ
{
    class Program
    {
        static void Main(string[] args) //Main Method
        {
            Console.WriteLine("Welcome To The Product Review Management Program");

            //List : A List Class Can Be Used To Create A Collection Of A Any Type
            List<ProductReview> productReviewList = new List<ProductReview>() 
            {
                new ProductReview(){Product_ID=1,User_ID=1,Rating=2,Review="Good",isLike=true},
                new ProductReview(){Product_ID=2,User_ID=1,Rating=4,Review="Good",isLike=true},
                new ProductReview(){Product_ID=3,User_ID=1,Rating=5,Review="Good",isLike=true},
                new ProductReview(){Product_ID=4,User_ID=1,Rating=6,Review="Good",isLike=false},
                new ProductReview(){Product_ID=5,User_ID=1,Rating=2,Review="nice",isLike=true},
                new ProductReview(){Product_ID=6,User_ID=1,Rating=1,Review="bad",isLike=true},
                new ProductReview(){Product_ID=8,User_ID=1,Rating=1,Review="Good",isLike=false},
                new ProductReview(){Product_ID=8,User_ID=1,Rating=9,Review="nice",isLike=true},
                new ProductReview(){Product_ID=2,User_ID=1,Rating=10,Review="nice",isLike=true},
                new ProductReview(){Product_ID=10,User_ID=1,Rating=8,Review="nice",isLike=true},
                new ProductReview(){Product_ID=11,User_ID=1,Rating=3,Review="nice",isLike=true}
            };
            foreach (var list in productReviewList) //Executing Each Element Present In List
            {
                Console.WriteLine("Product ID:- " + list.Product_ID + " " + "User ID:- " + list.User_ID
                    + " " + "Rating:- " + list.Rating + " " + "Review:- " + list.Review + " " + "isLike:- " + list.isLike);
            }
        }
    }
}


