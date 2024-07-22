using System.ComponentModel.DataAnnotations;

namespace Resturant.ResultModels
{
    public class OpdateOneCustomerInputModel
    {
        [Key]
        public long MyId { get; set; }

        public string FName { get; set; }

        public string LName { get; set; }

        public string PhoneNubmber { get; set; }

        public string Address { get; set; }

        public int Eshterak { get; set; }
    }
}