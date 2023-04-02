using Microsoft.AspNetCore.Mvc;
using PetShopProject.Data;
using PetShopProject.Models;
using PetShopProject.Repositories;
using System.Diagnostics;

namespace PetShopProject.Controllers
{
    public class CatalogController : Controller
    {
        private readonly IRepository dbRepository;
        private readonly ILogger<CatalogController> _logger;
        public CatalogController(IRepository _dbRepository, ILogger<CatalogController> logger)
        {
            dbRepository = _dbRepository;
            _logger = logger;
        }
        public IActionResult CatalogPage()
        {
            var animals = dbRepository.GetAllAnimals();
            var categories = dbRepository.GetAllCategories();
            ViewBag.Animals = animals;
            ViewBag.Category =categories;
            return View();
        }

        public IActionResult Fish()
        {
            var catId = dbRepository.GetCategoryByName("Fish");
            var animals = dbRepository.GetAnimalsByCategory(catId.categoryId);
            ViewBag.Animals = animals;
            ViewBag.Category = "Fish";

            return View();

        }
        public IActionResult Reptile()
        {
            var catId = dbRepository.GetCategoryByName("Reptile");
            var animals = dbRepository.GetAnimalsByCategory(catId.categoryId);
            ViewBag.Animals = animals;
            ViewBag.Category = "Reptile";

            return View();

        }
        public IActionResult Amphibian()
        {
            var catId = dbRepository.GetCategoryByName("Amphibian");
            var animals = dbRepository.GetAnimalsByCategory(catId.categoryId);
            ViewBag.Animals = animals;
            ViewBag.Category = "Amphibian";

            return View();

        }
        public IActionResult Mammal()
        {
            var catId = dbRepository.GetCategoryByName("Mammal");
            var animals = dbRepository.GetAnimalsByCategory(catId.categoryId);
            ViewBag.Animals = animals;
            ViewBag.Category = "Mammal";

            return View();

        }
        public IActionResult Bird()
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
