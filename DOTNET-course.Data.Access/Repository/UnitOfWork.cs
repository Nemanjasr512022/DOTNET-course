using DOTNET_course.Data.Access.Data;
using DOTNET_course.Data.Access.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET_course.Data.Access.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public ICategoryRepository CategoryRepository { get; private set; }
        public IProductRepository ProductRepository { get; private set; }
        public ICompanyRepository Company { get; private set; }

        public ApplicationDbContext _db;

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            CategoryRepository = new CategoryRepository(_db);
            ProductRepository = new ProductRepository(_db);
            Company = new CompanyRepository(_db);
        }
        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
