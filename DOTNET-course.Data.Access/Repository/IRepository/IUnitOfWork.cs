using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET_course.Data.Access.Repository.IRepository
{
     public interface IUnitOfWork
     {
        ICategoryRepository CategoryRepository { get; }
        IProductRepository ProductRepository { get; }
        ICompanyRepository Company { get; }
        void Save();
     }
}
