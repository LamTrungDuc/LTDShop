using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LTDShop.Web.Models
{
    // Tạo các tầng viewModels tương ứng với các tầng data
    public class PostCategoryViewModel
    {
        public int ID { set; get; }

        public string Name { set; get; }

        public string Alias { set; get; }

        public string Description { set; get; }
        public int? ParentID { set; get; }
        public int? DisplayOrder { set; get; }

        public string Image { set; get; }

        public bool? HomeFlag { set; get; }

        public virtual IEnumerable<PostViewModel> Posts { set; get; }

        public DateTime? CreateDate { set; get; }
        public string CreatedBy { set; get; }

        public DateTime? UpdatedDate { set; get; }
        public string UpdateBy { set; get; }
        public string MetaKeyword { set; get; }


        public string MetaDescription { set; get; }

        public bool Status { set; get; }
    }
}