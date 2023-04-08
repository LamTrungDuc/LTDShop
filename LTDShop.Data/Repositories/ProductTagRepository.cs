using LTDShop.Data.Infrastructure;
using LTDShop.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTDShop.Data.Repositories
{
    public interface IProducTagRepository : IRepository<ProductTag>
    {

    }
    public class ProductTagRepository : RepositoryBase<ProductTag> ,IProducTagRepository
    {
        public ProductTagRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
