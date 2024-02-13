using DataAccess.Abstracts;
using Entities.Concretes;


namespace DataAccess.Concretes
{
    public class CategoryDal : ICategoryDal
    {
        public List<Category> categories;
        public CategoryDal()
        {
            categories = new List<Category>() { new Category { CategoryId=1,Name="C# içerikli kurslar"},
            new Category { Name="JAVA,",CategoryId=2 } };

        }
        public void Add(Category entity)
        {
            categories.Add(entity);
        }

        public void Delete(Category entity)
        {
            var deletedCategory = categories.First(c => c.CategoryId == entity.CategoryId);
            categories.Remove(deletedCategory);
        }

        public Category Get(int CategoryId)
        {
            return categories.First(c => c.CategoryId == CategoryId); ;
        }

        public List<Category> GetAll()
        {
            return categories;
        }

        public void Update(Category entity)
        {
            var updatedCategory = categories.First(c=>c.CategoryId == entity.CategoryId);
            updatedCategory.CategoryId = entity.CategoryId;
          
            updatedCategory.Name = entity.Name;
            
            
        }
    }
}
