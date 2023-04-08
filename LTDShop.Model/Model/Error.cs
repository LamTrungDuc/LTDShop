﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTDShop.Model.Model
{
    [Table("Errors")]
   public class Error
    {
        [Key]
        public int ID { set; get; }
        public string Message { set; get; }
        public string StackTrace { set; get; }
        public DateTime CreateDate { set; get; }
    }
}
