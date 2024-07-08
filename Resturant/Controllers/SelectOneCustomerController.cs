using Microsoft.AspNetCore.Mvc;

namespace Resturant.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SelectOneCustomerController : Controller
    {

        [HttpPost]
        public object SelectOneCustomerr(Customers model)
        {
            return new Customers();
        }

    }
}
