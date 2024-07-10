using System.ComponentModel.DataAnnotations;

namespace Resturant
{
    public class FoodOrderStatus
    {
        [Key]
        public int Id { get; set; }
        public string StatusName { get; set; }

    }
}
