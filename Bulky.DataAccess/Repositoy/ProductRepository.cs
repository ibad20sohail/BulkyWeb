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
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        void IProductRepository.Update(Product obj)
        {
            _db.Update(obj);
        }
    }
}
