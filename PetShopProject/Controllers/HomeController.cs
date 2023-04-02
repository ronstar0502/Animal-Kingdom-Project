using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using PetShopProject.Data;
using PetShopProject.Models;
using PetShopProject.Repositories;
using System.Diagnostics;

namespace PetShopProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepository dbRepository;
        public HomeController( ILogger<HomeController> logger, IRepository _dbRepository)
        {
            _logger = logger;
            dbRepository = _dbRepository;
        }
        public IActionResult HomePage()
        {
            var topAnimals = dbRepository.GetTopAnimals();      
            ViewData["topAnimals"] =topAnimals;
            return View();
        }

        public IActionResult DetailsPage(int Id)
        {
            try
            {
                var animalDetails = dbRepository.GetAnimalById(Id);
                var animalComments = dbRepository.GetCommentsForAnimal(Id);
                var category = dbRepository.GetCategoryById(animalDetails.CategoryId);
                ViewBag.Comments = animalComments;
                ViewBag.animalDetails = animalDetails;
                ViewBag.Category = category;
                _logger.LogInformation($"Succefully entered the animal details page==> {animalDetails!.AnimalId}");

            }
            catch (Exception e)
            {
                _logger.LogError(e, $"error occured while trying to enter an animal details page :{e.GetBaseException().Message}");
                throw;
            }

            return View();
        }
        [HttpPost]
        public IActionResult AddComment(Comment comment)
        {
            try
            {
                
                dbRepository.AddComment(comment);
                _logger.LogInformation($"Succefully added a comment to an animal details page ==> {comment.AnimalId}");

            }
            catch (Exception e)
            {

                _logger.LogError(e, $"error occured while trying to add a comment to animals details page :{e.GetBaseException().Message}");
            }
            

            return Redirect($"/Home/DetailsPage/{comment.AnimalId}");
        }
        [HttpPost]
        public IActionResult AddLike(int Id)
        {
            var comment= dbRepository.GetCommentById(Id);
            dbRepository.AddLike(comment);
            return Redirect($"/Home/DetailsPage/{comment.AnimalId}");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}