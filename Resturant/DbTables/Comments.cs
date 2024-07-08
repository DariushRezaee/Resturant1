using System.ComponentModel.DataAnnotations;

namespace Resturant.DbTables
{
    public class Comments
    {
        [Key]
        public int Id { get; set; }

        public string CommentText { get; set; }

        public int FoodId { get; set; }
    }
}/////////////////////////////
/////1234567890-
///
