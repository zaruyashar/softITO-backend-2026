using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RepositUnitWorkApp.Data.Repository.IRepository;
using RepositUnitWorkApp.Model;
using RepositUnitWorkApp.Model.ViewModels;

namespace RepositUnitWorkApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class VehicleController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _hostEnvironment;

        public VehicleController(IUnitOfWork unitOfWork, IWebHostEnvironment hostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _hostEnvironment = hostEnvironment;
        }

        public IActionResult Index()
        {
            var vehicleList = _unitOfWork.Vehicle.GetAll();
            return View(vehicleList);
        }

        [HttpGet]
        public IActionResult Upsert(int? id = 0)
        {
            VehicleViewModel vehicleViewModel = new()
            {
                Vehicle = new(),
                VehicleTypeList = _unitOfWork.VehicleType.GetAll().Select(x => new SelectListItem
                {
                    Text = x.TypeName,
                    Value = x.Id.ToString()
                })
            };

            if (id == null || id <= 0)
            {
                return View(vehicleViewModel);
            }

            vehicleViewModel.Vehicle = _unitOfWork.Vehicle.GetFirstOrDefault(x => x.Id == id);

            if (vehicleViewModel.Vehicle == null)
            {
                return View(vehicleViewModel);
            }

            return View(vehicleViewModel);
        }

        
        [HttpPost]
        public IActionResult Upsert(VehicleViewModel vehicleViewModel, IFormFile file)
        {
            string wwwRootPath = _hostEnvironment.WebRootPath;

            if (file != null)
            {
                string fileName = Guid.NewGuid().ToString();
                var uploadRoot = Path.Combine(wwwRootPath, @"img\vehicles");
                var extension = Path.GetExtension(file.FileName);

                if (vehicleViewModel.Vehicle.Photo != null)
                {
                    var oldPicPath = Path.Combine(wwwRootPath, vehicleViewModel.Vehicle.Photo);

                    if (System.IO.File.Exists(oldPicPath))
                    {
                        System.IO.File.Delete(oldPicPath);
                    }
                }

                using (var fileStream = new FileStream(Path.Combine(uploadRoot, fileName + extension),
                     FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }

                vehicleViewModel.Vehicle.Photo = @"\img\vehicles\" + fileName + extension;
            }

            if (vehicleViewModel.Vehicle.Id <= 0)
            {
                _unitOfWork.Vehicle.Add(vehicleViewModel.Vehicle);
            }
            else
            {
                _unitOfWork.Vehicle.Update(vehicleViewModel.Vehicle);
            }
            _unitOfWork.Save();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id <= 0)
            {
                return NotFound();
            }

            var vehicle = _unitOfWork.Vehicle.GetFirstOrDefault(x => x.Id == id);
            _unitOfWork.Vehicle.Remove(vehicle);
            _unitOfWork.Save();
            return RedirectToAction("Index");
        }
    }
}

