

using ShopApp.DAL.Context;
using ShopApp.DAL.Interfaces;
using ShopApp.DAL.Models;

namespace ShopApp.DAL.Daos
{
    public class CategoryDb : ICategoryDb
    {
        public CategoryDb(ShopContext context) 
        
        { 
            this.context = context;
        }
        
        public CategoryModel GetCategory(int id) { 

            throw new NotImplementedException();
        
        }

        public List<CategoryModel> GetCategories() 

        {
            throw new NotImplementedException(); 
        
        }

        public void UpdateCategory(CategoryUpdateModel CategoryAdd) 
        
        { 
            throw new NotImplementedException();
        
        }

        public void SaveCategory(CategoryAddModel CategoryAdd)
        { 
            throw new NotImplementedException();
        
        }

        public void UpdateCategory(CategoryUpdateModel CategoryAdd) 
        
        {
            throw new NotImplementedException();
            
        }


    }
}
