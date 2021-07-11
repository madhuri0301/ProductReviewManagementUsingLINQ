using System;
using System.Collections.Generic;
using System.Text;

namespace ProductReviewManagementLINQ
{
    public class ProductReview
    {
        public int Product_ID { get; set; }
        public int User_ID { get; set; }
        public double Rating { get; set; }
        public string Review { get; set; }
        public bool isLike { get; set; }
    }
}
