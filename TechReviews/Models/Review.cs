using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TechReviews.Models
{
    public class Review
    {
        [Key]
        public int ReviewID { get; set; }
        [Display(Name ="Product Name")]
        public string Title { get; set; }
        [Display(Name ="Write your review here")]
        public string Content { get; set; }
        [Display(Name ="Published date")]
        public DateTime PublishDate { get; set; }
        [Display(Name ="URL to product image")]
        public string ProductImg { get; set; }
        [Display(Name ="Rate the product from 1-10")]
        public double Rating { get; set; }
        public double Price { get; set; }
        [Display(Name ="Please enter Low, Mid, or High")]
        public string Budget { get; set; }

        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

    }
}