
using System.Collections.Generic;
using System.Linq;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Model;

namespace TeduShop.Data.Repositories
{
    public interface IProductRepository
    {
        //IEnumerable<Product> GetByAlias(string alias);
    }

    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(DbFactory dbFactory)
            : base(dbFactory)
        {

        }

        //public IEnumerable<Product> GetByAlias(string alias)
        //{
        //    return this.DbContext.productCategories.Where(x => x.Alias == alias);
        //}
    }
}
