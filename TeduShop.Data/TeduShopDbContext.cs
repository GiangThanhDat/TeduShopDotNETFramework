
using System.Data.Entity;
using TeduShop.Model.Model;

namespace TeduShop.Data
{
    public class TeduShopDbContext : DbContext
    {
        public TeduShopDbContext() : base("TeduShopConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
        public DbSet<Footer> Footers { set; get; }
        public DbSet<Menu> Menus { set; get; }
        public DbSet<MenuGroup> MenuGroup { set; get; }
        public DbSet<Order> Orders { set; get; }
        public DbSet<OrderDetail> OrderDetails { set; get; }
        public DbSet<Page> Pages { set; get; }
        public DbSet<Post> Posts { set; get; }
        public DbSet<PostCategory> PostCategorys { set; get; }
        public DbSet<PostTag> PostTags { set; get; }
        public DbSet<Product> Products { set; get; }
        public DbSet<ProductCategory> productCategories { set; get; }

        public DbSet<ProductTag> ProductTags { set; get; }

        public DbSet<Slide> Slides { set; get; }

        public DbSet<SupportOnline> SupportOnlines { set; get; }

        public DbSet<SystemConfig> systemConfigs { set; get; }
        public DbSet<VisitorStatistic> VisitorStatistics {set;get;}
        public DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(DbModelBuilder builder)
        {

        }
    }
}
