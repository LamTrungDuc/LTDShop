using LTDShop.Data.Infrastructure;
using LTDShop.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTDShop.Data.Repositories
{
    public interface IPostRepository : IRepository<Post>
    {
        IEnumerable<Post> GetAllByTag(string tag, int pageIdex, int pageSize, out int totalRow);
    }
   public class PostRepository : RepositoryBase<Post> ,IPostRepository
    {
        public PostRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
        // Dùng Linq join 2 bảng lấy ra TagID truyền vào tag , Lấy cái totalRow = query làm nhiệm vụ phân trang

        public IEnumerable<Post> GetAllByTag(string tag, int pageIdex, int pageSize, out int totalRow)
        {
            var query = from p in DbContext.posts
                        join pt in DbContext.postTags
                        on p.ID equals pt.PostID
                        where pt.TagID == tag && p.Status
                        orderby p.CreateDate descending
                        select p;
            totalRow = query.Count();
            query = query.Skip((pageIdex - 1) * pageSize).Take(pageSize);
            return query;


        }
    }
}
