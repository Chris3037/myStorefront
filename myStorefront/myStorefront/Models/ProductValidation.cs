using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace myStorefront.Models
{
    [MetadataType(typeof(ProductMetaData))]

    public partial class Category
    {
        public List<Models.Product> AllProducts;
    }

    public partial class Product
    {
    }

    public class ProductMetaData
    {
        [Required(ErrorMessage = "You need to enter a product name")
        , Display(Name = "Product Name")
        , MaxLength(100, ErrorMessage= "The product name is too long")]
        public string ProductName;

        [Required(ErrorMessage = "You need to enter a price (e.g. 10.99)")
        , Display(Name = "Price")]
        public string ProductPrice;

        [Required(ErrorMessage = "You need to enter a quantity")
        , Display(Name = "Quantity")]
        public string ProductQuantity;

        [Display(Name = "Description (Optional)")]
        public string ProductDescription;

        [Display(Name = "Category ID")]
        public string CategoryID;

        [Display(Name = "Supplier ID")]
        public string SupplierID;
    }
}
