
using ShopApp.DAL.Models;
namespace ShopApp.DAL.Interfaces
{
    public interface ICategoryDb {
        List<CategoryModel> GetCategories();
        CategoryModel GetCategory(int CategoryId);

        void SaveCategory(CategoryAddModel CategoryAdd);

        void UpdateCategory(CategoryUpdateModel CategoryAdd);

        void RemoveCategory(CategoryRemoveModel categoryAdd);
    }
}
