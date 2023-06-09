﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTDShop.Model.Model
{
    [Table("Tags")]
   public class Tag
    {
        [Key]
        [MaxLength(50)]
        public string ID { set; get; }
        [MaxLength(50)]
        [Required]
        public string Name { set; get; }
        [Required]
        [MaxLength(50)]
        public string Type { set; get; }
    }
}
