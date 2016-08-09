using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SMBusiness.Models
{
    public class RequestAQuoteModel
    {
        [Required]
        [DisplayName("Project Type")]
        public string ProjectType { get; set; }

        [Required]
        [DataType(DataType.PostalCode)]
        public string Zipcode { get; set; }

        [Required]
        [DisplayName("Contact Name")]
        public string ContactName { get; set; }
        
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DisplayName("Day time phone")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Please include the area code first.")]
        public string DayTimePhone { get; set; }

        [Required]
        [DisplayName("Project Description")]
        [StringLength(5000, MinimumLength = 15)]
        [DataType(DataType.MultilineText)]
        public string ProjectDescription { get; set; }
    }
}