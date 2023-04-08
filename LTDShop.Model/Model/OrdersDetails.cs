using LTDShop.Model.Asbtract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTDShop.Model.Model
{
    [Table("OrderDetails")]
   public class OrdersDetails 
    {
        [Key]
        [Column(Order = 1)]
        public int OrderID { set; get; }
        [Key]
        [Column(Order = 2)]
        public int ProductID { set; get; }
        public int Quantity { set; get; }
     
        [ForeignKey("OrderID")]
        public virtual Oder Oders { set; get; }

        [ForeignKey("ProductID")]
        public virtual Product Product { set; get; }

    }
}
