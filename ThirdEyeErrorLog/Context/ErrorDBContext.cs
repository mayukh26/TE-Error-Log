using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ThirdEyeErrorLog.Models;

namespace ThirdEyeErrorLog.Context
{
    public class ErrorDBContext : DbContext
    {
        public ErrorDBContext() : base("name=ErrorDBSet")
        {
        }
        public virtual DbSet<ErrorList> ErrorLists { get; set; }
    }
}