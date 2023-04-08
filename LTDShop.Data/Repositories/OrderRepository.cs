using LTDShop.Data.Infrastructure;
using LTDShop.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTDShop.Data.Repositories
{
    public interface IOrderRepository : IRepository<Oder>
    {

    }
   public class OrderRepository : RepositoryBase<Oder> ,IOrderRepository
    {
        public OrderRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
