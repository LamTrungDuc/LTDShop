using AutoMapper;
using LTDShop.Model.Model;
using LTDShop.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace LTDShop.Web.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            
            Mapper.CreateMap<Post, PostViewModel>();
            Mapper.CreateMap<PostCategory, PostCategoryViewModel>();
            Mapper.CreateMap<Tag, TagViewModel>();
        }
    } 
}