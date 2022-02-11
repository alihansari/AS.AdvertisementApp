using AS.AdvertisementApp.DataAccess.Contexts;
using AS.AdvertisementApp.DataAccess.Interfaces;
using AS.AdvertisementApp.DataAccess.Repositories;
using AS.AdvertisementApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS.AdvertisementApp.DataAccess.UnitOfWork
{
    public class Uow
    {
        private readonly AdvertisementContext _context;
        public Uow(AdvertisementContext context)
        {
            _context = context;
        }
        public IRepository<T> GetRepository<T>() where T : BaseEntity
        {
            return new Repository<T>(_context);
        }
        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
