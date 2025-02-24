using DOTNET_course.Data.Access.Data;
using DOTNET_course.Data.Access.Repository.IRepository;
using DOTNET_course.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET_course.Data.Access.Repository
{
    public class ProductRepository : Repository<Product> , IProductRepository
    {
        private ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db) : base(db) 
        {
            _db = db;
            
        }

        public void Update(Product product)
        {
            _db.Products.Update(product);
        }
    }
}
