using System.ComponentModel.DataAnnotations;

namespace Resturant
{
    public class LikeManagement
    {
        [Key]
        public int Id { get; set; }
        public int CostumerId { get; set; }

        public int CommentId { get; set; }

        public DateTime LikeDate { get; set; }

    }
}
