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
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        private ApplicationDbContext _db;

        public CompanyRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        void ICompanyRepository.update(Company company)
        {
            _db.Companies.Update(company);
        }
    }
}
