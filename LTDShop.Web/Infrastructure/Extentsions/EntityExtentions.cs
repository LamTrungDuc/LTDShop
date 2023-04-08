using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LTDShop.Model.Model;
using LTDShop.Web.Models;

namespace LTDShop.Web.Infrastructure.Extentsions
{
    // tạo ra các phương thức mở rộng cho một đối tượng nào đấy 
    public static class EntityExtentions
    {
        public static void UpdatePostCategory(this PostCategory postCategory, PostCategoryViewModel posCategoryVM)
        {
            postCategory.ID = posCategoryVM.ID;
            postCategory.Name = posCategoryVM.Name;
            postCategory.Alias = posCategoryVM.Alias;
            postCategory.Description = posCategoryVM.Description;
            postCategory.ParentID = posCategoryVM.ParentID;
            postCategory.DisplayOrder = posCategoryVM.DisplayOrder;
            postCategory.Image = posCategoryVM.Image;
            postCategory.HomeFlag = posCategoryVM.HomeFlag;
            postCategory.CreateDate = posCategoryVM.CreateDate;
            postCategory.CreatedBy = posCategoryVM.CreatedBy;
            postCategory.UpdatedDate = posCategoryVM.UpdatedDate;
            postCategory.UpdateBy = posCategoryVM.UpdateBy;
            postCategory.MetaKeyword = posCategoryVM.MetaKeyword;
            postCategory.MetaDescription = posCategoryVM.MetaDescription;
            postCategory.Status = posCategoryVM.Status;



        }

        public static void UpdatePost(this Post post, PostViewModel postVM)
        {
            post.ID = postVM.ID;
            post.Name = postVM.Name;
            post.Alias = postVM.Alias;
            post.CategoryID = postVM.CategoryID;
            post.Image = postVM.Image;
            post.Description = postVM.Description;
            post.Content = postVM.Content;
            post.HomeFlag = postVM.HomeFlag;
            post.HotFlag = postVM.HotFlag;
            post.ViewCount = postVM.ViewCount;
            post.CreateDate = postVM.CreateDate;
            post.CreatedBy = postVM.CreatedBy;
            post.UpdatedDate = postVM.UpdatedDate;
            post.UpdateBy = postVM.UpdateBy;
            post.MetaKeyword = postVM.MetaKeyword;
            post.MetaDescription = postVM.MetaDescription;
            post.Status = postVM.Status;
        }
    }
}