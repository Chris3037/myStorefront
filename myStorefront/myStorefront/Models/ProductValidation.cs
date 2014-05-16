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
    }
}