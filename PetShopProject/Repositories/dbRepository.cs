

using Microsoft.EntityFrameworkCore;
using PetShopProject.Data;
using PetShopProject.Models;

namespace PetShopProject.Repositories
{
    public class dbRepository:IRepository
    {
        private readonly KingdomDBContext dbContext;

        public dbRepository(KingdomDBContext context)
        {
            dbContext = context;
        }

        IEnumerable<Animal>? IRepository.GetAllAnimals()
        {
            return dbContext.Animals.ToList();
        }
        Animal IRepository.GetAnimalById(int Id)
        {
            var animal = dbContext.Animals.SingleOrDefault(x => x.AnimalId == Id);
            return animal;
        }
        IEnumerable<Category>? IRepository.GetAllCategories()
        {
            return dbContext.Categories.ToList();
        }
        Category IRepository.GetCategoryById(int Id)
        {
            var category = dbContext.Categories.SingleOrDefault(x => x.categoryId == Id);
            return category;
        }
        Category IRepository.GetCategoryByName(string Name)
        {
            var category= dbContext!.Categories.SingleOrDefault(c => c.Name == Name);
            return category;
        }
        IEnumerable<Comment>? IRepository.GetCommentsForAnimal(int animalId)
        {
            IEnumerable<Comment> comments= dbContext.Comments.Where(x=>x.AnimalId==animalId).ToList();
            return comments;
        }
        IEnumerable<Animal>? IRepository.GetAnimalsByCategory(int CategoryId)
        {
            IEnumerable<Animal> animals = dbContext.Animals.Where(x => x.CategoryId == CategoryId).ToList();
            return animals;
        }
        IEnumerable<Animal> IRepository.GetTopAnimals()
        {
            var topAnimals = (from animal in dbContext!.Animals orderby animal.Comments!.Count descending select animal).Take(2).ToList();
            return topAnimals;
        }
        Comment IRepository.GetCommentById(int Id)
        {
            var comment= dbContext!.Comments.SingleOrDefault(x => x.commentId == Id);
            return comment;
        }
        void IRepository.AddComment(Comment comment) {
            var date = DateTime.Today;
            comment.CommentDate = date;
            dbContext.Comments.Add(comment);
            dbContext.SaveChanges();
        }
        void IRepository.AddLike(Comment comment)
        {
            comment.Likes++;
            dbContext.SaveChanges();
        }
        void IRepository.EditAnimalWithPhoto(int Id, string imageName, int age, string description)
        {
            var animalEdit = dbContext.Animals.SingleOrDefault(x => x.AnimalId == Id);
            animalEdit!.Description = description;
            animalEdit.Age =age;
            animalEdit.ImageName = imageName;
            dbContext.SaveChanges();
        }
        void IRepository.EditAnimalWithoutPhoto(int Id,int age, string description)
        {
            var animalEdit = dbContext.Animals.SingleOrDefault(x => x.AnimalId == Id);
            animalEdit!.Description = description;
            animalEdit.Age = age;
            dbContext.SaveChanges();
        }
        void IRepository.DeleteAnimal(int Id)
        {
            var animal = dbContext!.Animals.SingleOrDefault(x => x.AnimalId == Id);
            dbContext.Animals.Remove(animal);
            dbContext.SaveChanges();
        }
        void IRepository.AddAnimal(Animal animal)
        {
            dbContext.Animals.Add(animal);
            dbContext.SaveChanges();
        }
        void IRepository.UpdateAnimal(Animal animal)
        {
            dbContext.Animals.Update(animal);
            dbContext.SaveChanges();
        }

    }
}
