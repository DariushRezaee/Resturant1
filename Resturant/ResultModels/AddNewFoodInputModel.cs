using System.ComponentModel.DataAnnotations;

namespace Resturant.ResultModels
{
    public class AddNewFoodInputModel
    {
        [Key]
        public int Id { get; set; }

        public string FoodName { get; set; }
    }
}
