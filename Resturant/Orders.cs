using System.ComponentModel.DataAnnotations;

namespace Resturant
{
    public class Orders
    {
        [Key]
        public int Id { get; set; }

        public int CustomerId { get; set; }


        public int FoodId { get; set; }


        public DateTime OrderDate { get; set; }


        public string StatusId { get; set; }


        public int CustomerRank { get; set; }

    }
}
