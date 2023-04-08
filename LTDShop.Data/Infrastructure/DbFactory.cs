using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTDShop.Data.Infrastructure
{
   public class DbFactory : Disposable, IDbFactory
    {
         LTDShopDbContext dbContext;
        // kế thừa từ IDbFactory để tạo ra 1 đối tượng của dvContext
        public LTDShopDbContext Init()
        {
            return dbContext ?? (dbContext = new LTDShopDbContext());
        }
        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
