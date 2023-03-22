using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTDShop.Model.Asbtract
{
   public interface IAuditable
    {
        DateTime? CreateDate { set; get; }
        string CreatedBy { set; get; }
        DateTime? UpdatedDate { set; get; }
        string UpdateBy { set; get; }
        string MetaKeyword { set; get; }
        string MetaDescription { set; get; }
        bool Status { set; get; }

    }
}
