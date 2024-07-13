using Microsoft.AspNetCore.Mvc;
using Resturant.CustomerServices;
using Resturant.DbTables;
using Resturant.ResultModels;

namespace Resturant.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : Controller
    {
        [HttpGet]
        [Route("getAllCustomers")]
        public CustomerResultModel GetAllCustomers()
        {
            return CustomerService.GetAllCustomer();
        }

        [HttpGet]
        [Route("getOneCustomerData")]
        public CustomerResultModel GetOneCustomerData(long MyCustomerId)
        {
            return CustomerService.GetOneCustomerData();
        }

        [HttpGet]
        [Route("AddOneCustomers")]
        public CustomerResultModel AddNewCustomer(AddNewCustomerInputModel model)
        {
            return CustomerService.AddNewCustomer();
        }

        [HttpGet]
        [Route("UpdateOneCustomers")]
        public CustomerResultModel UpdateOneCustomer(OpdateOneCustomerInputModel model)
        {
            return CustomerService.UpdateOneCustomer();
        }


    }
}
