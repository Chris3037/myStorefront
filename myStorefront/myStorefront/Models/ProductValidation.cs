using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace myStorefront.Models
{
    [MetadataType(typeof(PostMetaData))]
    public partial class Product
    {
    }

    public class PostMetaData
    {
        [Required(ErrorMessage = "You need to enter a title")
        , Display(Name = "Title")]
        public string ProductTitle;

        [Required(ErrorMessage = "You need to enter a price")
        , Display(Name = "Price")]
        public string ProductPrice;

        [Required(ErrorMessage = "You need to enter a quantity")
        , Display(Name = "Quantity")]
        public string ProductQuantity;

        [Required(ErrorMessage = "You need to enter a description")
        , Display(Name = "Description")]
        public string ProductDescription;

        [Required(ErrorMessage = "You need to enter a category")
        , Display(Name = "Categoryy")]
        public string ProductCategory;

        [Required(ErrorMessage = "You need to enter a supplier")
        , Display(Name = "Supplier")]
        public string ProductSupplier;
    }
}