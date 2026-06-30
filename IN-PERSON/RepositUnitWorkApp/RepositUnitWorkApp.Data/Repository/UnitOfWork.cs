using RepositUnitWorkApp.Data.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositUnitWorkApp.Data.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public IVehicleRepository Vehicle => new VehicleRepository(_context);

        public IVehicleTypeRepository VehicleType => new VehicleTypeRepository(_context);

        public void Dispose()
        {
            _context.Dispose();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
