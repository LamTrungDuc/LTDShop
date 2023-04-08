using LTDShop.Data.Infrastructure;
using LTDShop.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTDShop.Data.Repositories
{
    public interface IOrderDetailRepository : IRepository<OrdersDetails>
    {

    }
   public class OrderDetailRepository :RepositoryBase<OrdersDetails>  ,IOrderDetailRepository 
    {
        public OrderDetailRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
