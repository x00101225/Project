using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Web.Mvc;

namespace Project2.Models
{
    public class UploadModel
    {
        [DisplayName("Enter Username:")]
        [Required(ErrorMessage = "Required field!")]
        public String UserName { get; set; }

        [DisplayName("Enter Embed Link")]
        [Required(ErrorMessage = "Required field!")]
        [AllowHtml]
        public string BlogText { get; set; }


    }
}