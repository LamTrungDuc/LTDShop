﻿using LTDShop.Model.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTDShop.Data
{
   public class LTDShopDbContext : DbContext
    {
        public LTDShopDbContext() : base("LTDShopConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
        public DbSet<Footer> Footers { set; get; }
        public DbSet<Menu> Menus { set; get; }
        public DbSet<MenuGroup> MenuGroups { set; get; }
        public DbSet<Oder> oders { set; get; }
        public DbSet<OrdersDetails> OrdersDetails { set; get; }
        public DbSet<Page> pages { set; get; }
        public DbSet<Post> posts { set; get; }
        public DbSet<PostCategory> postCategories { set; get; }
        public DbSet<PostTag> postTags { set; get; }
        public DbSet<Product> products { set; get; }
        public DbSet<ProductCategory> productCategories { set; get; }
        public DbSet<ProductTag> ProductTags { set; get; }
        public DbSet<Slide> Slides { set; get; }
        public DbSet<SupportOnline> supportOnlines { set; get; }
        public DbSet<SystemConfig> systemConfigs { set; get; }
        public DbSet<Tag> tags { set; get; }
        public DbSet<VisitedStatistic> visitedStatistics { set; get; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
        }
    }
}
