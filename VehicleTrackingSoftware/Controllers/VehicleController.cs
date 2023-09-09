using Microsoft.AspNetCore.Mvc;
using VehicleTrackingSoftware.Business.Operations;

namespace VehicleTrackingSoftware.Controllers
{
    public class VehicleController : Controller
    {
        private readonly VehicleOperations _vehicleOperations;
        public VehicleController(VehicleOperations vehicleOperations)
        {
            _vehicleOperations = vehicleOperations;
        }

        public IActionResult Index()
        {
            var vehicles = _vehicleOperations.Vehicles();

            return View(vehicles);
        }
    }
}