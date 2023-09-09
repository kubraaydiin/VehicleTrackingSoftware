using VehicleTrackingSoftware.Data.Entities;
using VehicleTrackingSoftware.Data.Repositories;

namespace VehicleTrackingSoftware.Business.Operations
{
    public class VehicleOperations
    {
        private readonly VehicleRepository _vehicleRepository;
        public VehicleOperations(VehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }

        public List<Vehicle> Vehicles()
        {
            var vehicles = _vehicleRepository.GetAll();
            return vehicles;
        }
    }
}
