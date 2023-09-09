using VehicleTrackingSoftware.Data.Entities;

namespace VehicleTrackingSoftware.Data.Repositories
{
    public class VehicleRepository
    {
        private readonly VehicleContext _vehicleContext;
        public VehicleRepository(VehicleContext vehicleContext)
        {
            _vehicleContext = vehicleContext;
        }

        public List<Vehicle> GetAll() 
        {
            var vehicles = _vehicleContext.Vehicles.ToList();
            return vehicles;
        }
    }
}
