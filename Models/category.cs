using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace mybroject.Models
{
    public class category
    {
        public int Id { get; set; }
        [Required]
        [Display(Name ="اسم الوظيفه")]
        public string cat_name { get; set; }
        [Required]
        [Display(Name ="وصف الوظيفه")]
        public string cat_description { get; set; }
    }
}