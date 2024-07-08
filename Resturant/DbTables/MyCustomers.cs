using System.ComponentModel.DataAnnotations;

namespace Resturant.DbTables
{
    public class MyCustomers
    {

        [Key]
        public int Id { get; set; }

        public string FName { get; set; }

        public string LName { get; set; }

        public int PhoneNubmber { get; set; }

        public string Address { get; set; }

        public int CodeEshterak { get; set; }
    }
}
