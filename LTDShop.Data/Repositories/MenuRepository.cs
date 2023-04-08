using LTDShop.Data.Infrastructure;
using LTDShop.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTDShop.Data.Repositories
{
    public interface IMenuRePository : IRepository<Menu>
    {

    }
   public class MenuRepository : RepositoryBase<Menu> , IMenuRePository
    {
        public MenuRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
