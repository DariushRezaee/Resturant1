using Resturant.ResultModels;

namespace Resturant.CustomerServices
{
    public interface ICustomerService
    {
        CustomerResultModel GetAllCustomers();

        CustomerResultModel GetOneCustomerData(long MyCustomerId);

        CustomerResultModel AddNewCustomer(AddNewCustomerInputModel model);

        CustomerResultModel UpdateOneCustomer(OpdateOneCustomerInputModel model);



    }
}
