﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTDShop.Model.Asbtract
{
   public abstract class Auditable :IAuditable
    {
     public DateTime? CreateDate { set; get; }
        [MaxLength(256)]
     public   string CreatedBy { set; get; }

     public   DateTime? UpdatedDate { set; get; }
        [MaxLength(256)]
        public string UpdateBy { set; get; }

        [MaxLength(256)]
        public string MetaKeyword { set; get; }
        [MaxLength(256)]
        public string MetaDescription { set; get; }

        public bool Status { set; get; }
    }
}
