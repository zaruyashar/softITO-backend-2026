using RepositUnitWorkApp.Data.Repository.IRepository;
using RepositUnitWorkApp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositUnitWorkApp.Data.Repository
{
    public class VehicleTypeRepository: Repository<VehicleType>, IVehicleTypeRepository
    {
        private readonly ApplicationDbContext _context;

        public VehicleTypeRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
