using System.ComponentModel.DataAnnotations;

namespace Resturant.ResultModels
{
    public class UpdateOneFoodInputModel
    {
        [Key]
        public int Id { get; set; }

        public string FoodName { get; set; }
    }
}
