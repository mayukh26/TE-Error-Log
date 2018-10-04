using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ThirdEyeErrorLog.Models
{
    public class ErrorList
    {
        [Key]
        public Int64 Id { get; set; }
        public string Name { get; set; }       
        public string Domain { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
       
    }
}