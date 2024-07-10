using Resturant.DbTables;
using System.ComponentModel.DataAnnotations;

namespace Resturant
{
    public class Orders
    {
        [Key]
        public int Id { get; set; }

        public long CustomerMyId { get; set; }
        public MyCustomers Customer { get; set; }


        public int FoodId { get; set; }
        public Foods Food { get; set; }


        public DateTime OrderDate { get; set; }


        public string StatusId { get; set; }
        public FoodOrderStatus Status { get; set; }


        public int CustomerRank { get; set; }

    }
}
