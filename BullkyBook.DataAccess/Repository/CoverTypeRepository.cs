using BullkyBook.DataAccess.Data;
using BullkyBook.DataAccess.Repository.IRepository;
using BullkyBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BullkyBook.DataAccess.Repository {
    public class CoverTypeRepository : Repository<CoverType>, ICoverTypeRepository {
        private readonly ApplicationDbContext _db;
        public CoverTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        void ICoverTypeRepository.Update(CoverType coverType)
        {
            _db.CoverTypes.Update(coverType);
        }
    }
}
