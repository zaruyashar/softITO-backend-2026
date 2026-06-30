using System;
using System.Collections.Generic;
using System.Text;

namespace RepositUnitWorkApp.Data.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IVehicleRepository Vehicle { get; }
        IVehicleTypeRepository VehicleType { get; }

        void Save();
    }
}
