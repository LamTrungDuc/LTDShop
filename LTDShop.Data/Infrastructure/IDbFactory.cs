using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTDShop.Data.Infrastructure
{
    // giao tiếp khởi tạo các đối tượng Entity 
    public interface IDbFactory :IDisposable
    {
        LTDShopDbContext Init();
    }
}
