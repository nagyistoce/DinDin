using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DinDin.Web.UI.Models
{
    public class ExpenseModel
    {
        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "When")]
        public DateTime When { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 4)]
        [DataType(DataType.Text)]
        [Display(Name = "What")]
        public string What { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "How much")]
        public string HowMuch { get; set; }
    }
}