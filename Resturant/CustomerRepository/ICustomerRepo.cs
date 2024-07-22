using Resturant.dbInputModel.customersModel;
using Resturant.ResultModels;

namespace Resturant.Repository
{
    public interface ICustomerRepo
    {

        List<CustomerResultModel> GetAllCustomers();

        CustomerResultModel GetOneCustomerData(long MyCustomerId);

        bool AddNewCustomer(AddNewCustomerInputModel model);

        bool UpdateOneCustomer(OpdateOneCustomerInputModel model);

    }
}
