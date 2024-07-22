using Microsoft.AspNetCore.Mvc;
using Resturant.CustomerServices;
using Resturant.DbTables;
using Resturant.Repository;
using Resturant.ResultModels;

namespace Resturant.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        [HttpGet]
        [Route("getAllCustomers")]
        public List<CustomerResultModel> GetAllCustomers()
        {
            return _customerService.GetAllCustomers();
        }

        [HttpGet]
        [Route("getOneCustomerData")]
        public CustomerResultModel GetOneCustomerData(long MyCustomerId)
        {
            return _customerService.GetOneCustomerData(MyCustomerId);
        }

        [HttpPost]
        [Route("AddOneCustomers")]
        public bool AddNewCustomer(AddNewCustomerInputModel model)
        {
            return _customerService.AddNewCustomer(model);
        }

        [HttpPost]
        [Route("UpdateOneCustomers")]
        public bool UpdateOneCustomer( OpdateOneCustomerInputModel model)
        {
            return _customerService.UpdateOneCustomer( model);
        }


    }
}
