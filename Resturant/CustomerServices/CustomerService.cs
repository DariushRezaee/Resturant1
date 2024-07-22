using Resturant.Db;
using Resturant.Repository;
using Resturant.ResultModels;

namespace Resturant.CustomerServices
{
    public class CustomerService : ICustomerService
    {
        ICustomerRepo _customerRepo;

        public CustomerService(ICustomerRepo customerRepo)
        {
            _customerRepo = customerRepo;
        }
    

        public bool AddNewCustomer(AddNewCustomerInputModel model)
        {
            return _customerRepo.AddNewCustomer(model);
        }

        public List<CustomerResultModel> GetAllCustomers()
        {
            return _customerRepo.GetAllCustomers();
        }

        public CustomerResultModel GetOneCustomerData(long MyCustomerId)
        {
            return _customerRepo.GetOneCustomerData(MyCustomerId);
        }

        public bool UpdateOneCustomer(OpdateOneCustomerInputModel model)
        {
            if (model.MyId == null ||
               model.FName == null ||
               model.LName == null ||
               model.Address == null ||
               model.Eshterak == null ||
               model.PhoneNubmber == null)
            {
                return false;
            }
            var a = _customerRepo.UpdateOneCustomer( model);
            return a;
               
        }

          
    }
}
