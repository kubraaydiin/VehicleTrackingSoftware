using Microsoft.AspNetCore.Mvc;
using VehicleTrackingSoftware.Business.Operations;
using VehicleTrackingSoftware.Models;

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
            var vehicles = _vehicleOperations.Vehicles().Select(x => new VehicleViewModel
            {
                NumberPlate = x.NumberPlate,
                StartingPoint = x.StartingPoint,
                Destination = x.Destination,
            }).ToList();

            return View(vehicles);
        }
    }
}