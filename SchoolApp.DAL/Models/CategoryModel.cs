

namespace ShopApp.DAL.Models
{
    public class CategoryModel
    {
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public string? Description { get; set; }
        
        public DateTime Creation_Date { get; set; }

        public DateTime? Creation_user { get; set; }

    }
}
