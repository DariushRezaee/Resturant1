using Microsoft.EntityFrameworkCore;
using Resturant.CustomerServices;
using Resturant.Db;
using Resturant.dbInputModel.customersModel;
using Resturant.DbTables;
using Resturant.ResultModels;

namespace Resturant.Repository
{
    public class CustomerRepo : ICustomerRepo
    {
        MyDbContext _db;

        public CustomerRepo(MyDbContext db2)
        {
            _db = db2;
        }
        ///
        public bool AddNewCustomer(AddNewCustomerInputModel model)
        {
            try
            {
                _db.Customers.Add(new MyCustomers()
                {
                    FName = model.FName,
                    LName = model.LName,
                    Address = model.Address,
                    Eshterak = model.Eshterak,
                    PhoneNubmber = model.PhoneNubmber
                });
                _db.SaveChanges();
                
                return true;
            }
            catch (Exception ex) { return false; }
        }
        public List<CustomerResultModel> GetAllCustomers()
        {
            var x = _db.Customers.Select(x => new CustomerResultModel
            {
                Id = x.MyId,
                FName = x.FName,
                LName = x.LName,
                PhoneNubmber = x.PhoneNubmber,
                Eshterak = x.Eshterak
            }).ToList();
            _db.SaveChanges();
            return x;
        }

        public CustomerResultModel GetOneCustomerData(long MyCustomerId)
        {
            var SelectOneCustomer = _db.Customers.FirstOrDefault(x => x.MyId == MyCustomerId);
            var result2 = Mapper.ConvertMyCustomers2CustomerResultModel(SelectOneCustomer);
            _db.SaveChanges();
            return result2;
            
        }

        public bool UpdateOneCustomer(OpdateOneCustomerInputModel model)
        {
            var UpdateOneCustomer = _db.Customers.FirstOrDefault(x => x.MyId == model.MyId);
            UpdateOneCustomer.FName = model.FName;
            UpdateOneCustomer.LName = model.LName;
            UpdateOneCustomer.Address = model.Address;
            UpdateOneCustomer.Eshterak = model.Eshterak;
            UpdateOneCustomer.PhoneNubmber = model.PhoneNubmber;
            _db.SaveChanges();
            return true;
        }


    }
}
