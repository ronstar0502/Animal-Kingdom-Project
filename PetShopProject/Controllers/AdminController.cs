using Microsoft.AspNetCore.Mvc;
using PetShopProject.Data;
using PetShopProject.Models;
using System.Diagnostics;
using NLog;
using Microsoft.EntityFrameworkCore;
using PetShopProject.Repositories;
using PetShopProject.Migrations;

namespace PetShopProject.Controllers
{
    public class AdminController : Controller
    {
        private readonly IRepository dbRepository;
        private readonly ILogger<AdminController> _logger;
        private readonly IWebHostEnvironment hostEnviremont;
        public AdminController(IRepository _dbRepository, ILogger<AdminController> logger, IWebHostEnvironment hostEnviremont)
        {
            dbRepository = _dbRepository;
            _logger = logger;
            this.hostEnviremont = hostEnviremont;
        }
        public IActionResult AdminHome()
        {
            var animals = dbRepository.GetAllAnimals();
            var categories = dbRepository.GetAllCategories();
            ViewData["animals"] = animals;
            ViewData["categories"] = categories;
            return View();
        }

        public IActionResult Edit(int Id)
        {
            var animalDetails = dbRepository.GetAnimalById(Id);
            var category = dbRepository.GetCategoryById(animalDetails.CategoryId);
            ViewBag.animalDetails = animalDetails;
            ViewBag.Category = category;
            return View();
        }
        [HttpPost]
        public IActionResult EditAnimal(AnimalViewModel model, IFormFile photo)
        {
            string imageName = model.Animal.ImageName;
            try
            {
                string wwwRootPath = hostEnviremont.WebRootPath;
                if (photo != null)
                {
                    var fileName = photo.FileName;
                    var uploads = Path.Combine(wwwRootPath, @"Images");

                    if (model.Animal.ImageName != null)
                    {
                        var oldImage = Path.Combine(wwwRootPath, model.Animal.ImageName.TrimStart('\\'));
                        if (System.IO.File.Exists(oldImage))
                        {
                            System.IO.File.Delete(oldImage);
                        }
                    }


                    using (FileStream fileStream = new FileStream(Path.Combine(uploads, fileName), FileMode.Create))
                    {
                        photo.CopyTo(fileStream);
                    }

                    imageName = @"Images\" + fileName;
                    dbRepository.EditAnimalWithPhoto(model.Animal.AnimalId, imageName, model.Animal.Age, model.Animal.Description);
                }
                else
                {
                    dbRepository.EditAnimalWithoutPhoto(model.Animal.AnimalId, model.Animal.Age, model.Animal.Description);
                    _logger.LogError($"photo invalid");
                    return RedirectToAction("AdminHome");
                }  
                _logger.LogInformation($"Edited Animal:{model.Animal.AnimalId}  ==> Succefully");

            }
            catch (Exception e)
            {
                _logger.LogError(e, $"error occured while trying to edit an animal :{e.GetBaseException().Message}");
            }
            return RedirectToAction("AdminHome");
        }
        public IActionResult Delete(int Id)
        {
            var animalDetails = dbRepository.GetAnimalById(Id);
            var category = dbRepository.GetCategoryById(animalDetails.CategoryId);
            ViewBag.animalDetails = animalDetails;
            ViewBag.Category=category;
            return View();
        }
        [HttpPost]
        public IActionResult DeleteAnimal(int Id)
        {
            try
            {
                dbRepository.DeleteAnimal(Id);
                _logger.LogInformation($"Deleted Animal:{Id} ==> Succefully");

            }
            catch (Exception e)
            {
                _logger.LogError(e, $"error occured while trying to delete an animal :{e.GetBaseException().Message}");

            }


            return RedirectToAction("AdminHome");
        }
        public IActionResult Add()
        {
            ViewBag.categories=dbRepository.GetAllCategories();
            return View();
        }
    
        [HttpPost]
        public IActionResult CreateAnimal(AnimalViewModel model, IFormFile photo)
        {
            string wwwRootPath = hostEnviremont.WebRootPath;
            if (photo != null)
            {
                var fileName = photo.FileName;
                var uploads = Path.Combine(wwwRootPath, @"Images");

                if (model.Animal.ImageName != null)
                {
                    var oldImage = Path.Combine(wwwRootPath, model.Animal.ImageName.TrimStart('\\'));
                    if (System.IO.File.Exists(oldImage))
                    {
                        System.IO.File.Delete(oldImage);
                    }
                }


                using (FileStream fileStream = new FileStream(Path.Combine(uploads, fileName), FileMode.Create))
                {
                    photo.CopyTo(fileStream);
                }

                model.Animal.ImageName = @"Images\" + fileName;
                if (model.Animal.AnimalId == 0)
                {
                    dbRepository.AddAnimal(model.Animal);
                }
                else
                {
                    dbRepository.UpdateAnimal(model.Animal);
                }
                return RedirectToAction("AdminHome");
            }
            return Redirect($"AdminHome/Add");
        }
       
        public IActionResult AdminFish()
        {
            var catId = dbRepository.GetCategoryByName("Fish");
            var animals = dbRepository.GetAnimalsByCategory(catId.categoryId);
            ViewBag.Animals = animals;
            ViewBag.Category = "Fish";

            return View();

        }
        public IActionResult AdminReptile()
        {
            var catId = dbRepository.GetCategoryByName("Reptile");
            var animals = dbRepository.GetAnimalsByCategory(catId.categoryId);
            ViewBag.Animals = animals;
            ViewBag.Category = "Reptile";

            return View();

        }
        public IActionResult AdminAmphibian()
        {
            var catId = dbRepository.GetCategoryByName("Amphibian");
            var animals = dbRepository.GetAnimalsByCategory(catId.categoryId);
            ViewBag.Animals = animals;
            ViewBag.Category = "Amphibian";

            return View();

        }
        public IActionResult AdminMammal()
        {
            var catId = dbRepository.GetCategoryByName("Mammal");
            var animals = dbRepository.GetAnimalsByCategory(catId.categoryId);
            ViewBag.Animals = animals;
            ViewBag.Category = "Mammal";

            return View();

        }
        public IActionResult AdminBird()
        {
            var catId = dbRepository.GetCategoryByName("Bird");
            var animals = dbRepository.GetAnimalsByCategory(catId.categoryId);
            ViewBag.Animals = animals;
            ViewBag.Category = "Bird";

            return View();

        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
