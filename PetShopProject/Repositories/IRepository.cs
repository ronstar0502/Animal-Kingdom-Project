using PetShopProject.Models;


namespace PetShopProject.Repositories
{
    public interface IRepository
    {
        IEnumerable<Animal>? GetAllAnimals();
        Animal GetAnimalById(int Id);
        IEnumerable<Category>? GetAllCategories();
        Category GetCategoryById(int Id);
        Category GetCategoryByName(string Name);
        IEnumerable<Comment>? GetCommentsForAnimal(int animalId);
        IEnumerable<Animal>? GetAnimalsByCategory(int CategoryId);
        IEnumerable<Animal> GetTopAnimals();
        Comment GetCommentById(int Id);
        void AddComment(Comment comment);
        void AddLike(Comment comment);
        void EditAnimalWithPhoto(int Id, string imageName, int age, string description);
        void EditAnimalWithoutPhoto(int Id, int age, string description);
        void DeleteAnimal(int Id);
        void AddAnimal(Animal animal);
        void UpdateAnimal(Animal animal);
    }
}
