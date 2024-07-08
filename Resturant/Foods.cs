using System.ComponentModel.DataAnnotations;

namespace Resturant
{
    public class Foods
    {
        [Key]
        public int Id { get; set; }

        public string FoodName { get; set; }
    }
}
