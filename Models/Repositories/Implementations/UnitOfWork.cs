using Microsoft.EntityFrameworkCore;
using WebDevelopment.Models.Context;
using WebDevelopment.Models.Repositories.Interfaces;

namespace WebDevelopment.Models.Repositories.Implementations
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public UnitOfWork(ApplicationDbContext context) 
        {
            _context = context;
        }
        public int Save()
        {
           return  _context.SaveChanges();
        }
    }
}
