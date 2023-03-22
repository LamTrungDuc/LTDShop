using LTDShop.Model.Asbtract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LTDShop.Model.Model
{
    [Table("Products")]
   public class Product : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        [Required]
        public string Name { set; get; }
        [Required]
        public string Alias { set; get; }
        public int CategoryID { set; get; }
        [Required]
        public string Images { set; get; }
        public XElement MoreImages { set; get; }
        public decimal Price { set; get; }
        public Decimal? PromotionPrice { set; get; }
        public int? Warranty { set; get; }
        [Required]
        public string Description { set; get; }
        [Required]
        public string Content { set; get; }

        public bool? HomeFlag { set; get; }
        public bool? HotFlag { set; get; }
        public int? ViewCount { set; get; }
        [ForeignKey("CategoryID")]
        public virtual ProductCategory ProductCategory { set; get; }
    }
}
