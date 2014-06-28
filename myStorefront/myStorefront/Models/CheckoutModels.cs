using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace myStorefront.Models
{
    public class PaymentInfo
    {
        //Validation for name on the credit card
        [Required(ErrorMessage = "Please enter a valid name")
        , Display(Name = "Enter the name on the credit card")]
        public string Name;

        //Validation for credit card number
        [Required(ErrorMessage = "Please enter a valid credit card number")
        , DataType(DataType.CreditCard)
        , Display(Name = "Enter the credit card number")
        , MaxLength(16, ErrorMessage="That is not the right length")
        , MinLength(16, ErrorMessage="That is not the right length")]
        public string CCNumber;

        //Make all of the validations
        [Required(ErrorMessage="Please enter a CVC (Located on the back of the card)")
        , Display(Name="Enter the CVC")
        , MaxLength(4, ErrorMessage="The CVC is 3 - 4 digits long")
        , MinLength(3, ErrorMessage="The CVC is 3 - 4 digits long")]
        public string CCVC;

        [Required(ErrorMessage = "Please enter the expiration month")
        , Display(Name = "Enter the expiration month")
        , MaxLength(2, ErrorMessage = "That expiration month is too long (Format: xx/xxxx)")
        , MinLength(2, ErrorMessage = "That expiration month is too short (Format: xx/xxxx)")]
        public string CCExpiryMonth;

        [Required(ErrorMessage = "Please enter the expiration year")
        , Display(Name = "Enter the expiration year")
        , MaxLength(2, ErrorMessage = "That expiration year is too long (Format: xx/xxxx)")
        , MinLength(2, ErrorMessage = "That expiration year is too short (Format: xx/xxxx)")]
        public string CCExpiryYear;
    }
}