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
    [Table("Pages")]
   public class Page :Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        [Required]
        [MaxLength(256)]
        public string Name { set; get; }
        [Column(TypeName ="Varchar")]
        [MaxLength(256)]
        [Required]
        public string Alias { set; get; }
        public string Content { set; get; }
    }
}
