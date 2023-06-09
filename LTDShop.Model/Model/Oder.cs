﻿using LTDShop.Model.Asbtract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTDShop.Model.Model
{
    [Table("Oders")]
    public class Oder : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        [Required]
        [MaxLength(256)]
        public string CustomerName { set; get; }
        [Required]
        [MaxLength(256)]
        public string CustomerAddress { set; get; }
        [Required]
        [MaxLength(256)]
        public string CustomerEmail { set; get; }
        [Required]
        [MaxLength(256)]
        public string CustomerMobile { set; get; }
        [Required]
        [MaxLength(256)]
        public string CustomerMessage { set; get; }
        [Required]
        [MaxLength(256)]
        public string PaymentMethod { set; get; }
        [Required]
        [MaxLength(256)]
        public DateTime? CreatedDate { set; get; }
        public string CreatedBy { set; get; }
        
        public string PaymentStatus { set; get;}
        
        public bool Status { set; get; }
        [ForeignKey("")]
        public virtual OrdersDetails OrdersDetails { set; get; }

    }
}
