using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTDShop.Model.Model
{
    [Table("Menus")]
   public class Menu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        [Required]
        public string Name { set; get; }
        [Required]
        [MaxLength(256)]
        public string URL { set; get; }

        public int? DisplayOder { set; get; }
        [Required]
        public int GroupID { set; get; }
        //Khoa ngoai liên kết với menu 
        [ForeignKey("GroupID")]
        public virtual MenuGroup MenuGroup { set; get; }
       
        [MaxLength(10)]
        public string Taget { set; get; }
        [Required]
        public bool Status { set; get; }



    }
}
