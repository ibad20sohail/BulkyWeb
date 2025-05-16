using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bulky.DataAccess.Data;
using Bulky.DataAccess.Repositoy.IRepository;
using Bulky.Models;

namespace Bulky.DataAccess.Repositoy
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        void ICategoryRepository.Update(Category obj)
        {
            _db.Update(obj);
        }
    }
}
