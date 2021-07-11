using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ProductReviewManagementLINQ
{
    public class ReviewManagement
    {
        public readonly DataTable dataTable = new DataTable();

        //Retriving Top Three Records From The List
        public void TopRecords(List<ProductReview> listProductReview)
        {
            var recordedData = (from productReviews in listProductReview
                                orderby productReviews.Rating descending
                                select productReviews).Take(3);
            foreach (var list in recordedData)
            {
                Console.WriteLine("Product ID:- " + list.Product_ID + " " + "User ID:- " + list.User_ID
                    + " " + "Rating:- " + list.Rating + " " + "Review:- " + list.Review + " " + "isLike:- " + list.isLike);
            }
        }

        //Retriving The Given data From The List
        public void SelectedRecords(List<ProductReview> listProductReview)
        {
            var recordedData = from productReviews in listProductReview
                               where (productReviews.Product_ID == 1 || productReviews.Product_ID == 4 || productReviews.Product_ID == 9)
                               && productReviews.Rating > 3
                               select productReviews;
            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductID:- " + list.Product_ID + " " + "UserID:- " + list.User_ID
                    + " " + "Rating:- " + list.Rating + " " + "Review:- " + list.Review + " " + "isLike:- " + list.isLike);
            }
        }
        //Retriving Count Of Records Present For Each Product Id
        public void RetrieveCountOfRecords(List<ProductReview> listProductReview)
        {
            var recordedData = listProductReview.GroupBy(x => x.Product_ID).Select(x => new { Product_ID = x.Key, Count = x.Count() });
            foreach (var list in recordedData)
            {
                Console.WriteLine(list.Product_ID + "----" + list.Count);
            }
        }
        //Retriving Only Product Id And Review From The List
        public void RetrieveIdAndReview(List<ProductReview> listProductReview)
        {
            var recordedData = listProductReview.Select(x => new { Product = x.Product_ID, Review = x.Review });
            foreach (var list in recordedData)
            {
                Console.WriteLine("Product Id :" + list.Product + " Review :" + list.Review);
            }
        }
    }
}
