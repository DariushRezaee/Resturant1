using Resturant.DbTables;
using System.ComponentModel.DataAnnotations;

namespace Resturant
{
    public class LikeManagement
    {
        [Key]
        public int Id { get; set; }
        public int CostumerId { get; set; }
        public MyCustomers Costumer { get; set; }

        public int CommentId { get; set; }
        public Comments Comment { get; set; }

        public DateTime LikeDate { get; set; }

    }
}
