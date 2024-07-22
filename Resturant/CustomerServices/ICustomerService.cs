﻿using Resturant.ResultModels;

namespace Resturant.CustomerServices
{
    public interface ICustomerService
    {
        List<CustomerResultModel> GetAllCustomers();

        CustomerResultModel GetOneCustomerData(long MyCustomerId);

        bool AddNewCustomer(AddNewCustomerInputModel model);

        bool UpdateOneCustomer(OpdateOneCustomerInputModel model);



    }
}
