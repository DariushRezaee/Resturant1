using Resturant.DbTables;
using Resturant.ResultModels;

namespace Resturant.CustomerServices
{
    public static class Mapper
    {
        public static CustomerResultModel ConvertMyCustomers2CustomerResultModel(MyCustomers Vooroodi)
        {
            var Result = new CustomerResultModel();
            Result.FName = Vooroodi.FName;
            Result.LName = Vooroodi.LName;
            Result.Address = Vooroodi.Address;
            Result.Eshterak = Vooroodi.Eshterak;
            Result.PhoneNubmber = Vooroodi.PhoneNubmber;
            return Result;
        }
        public static List<CustomerResultModel> ConvertListMyCustomers2CustomerResultModel(List<MyCustomers> Vooroodi)
        {
            var Result = new List<CustomerResultModel>();
            for (int i = 0;i < Vooroodi.Count;i++)
            {
                Result[i].FName = Vooroodi[i].FName;
                Result[i].LName = Vooroodi[i].LName;
                Result[i].Address = Vooroodi[i].Address;
                Result[i].Eshterak = Vooroodi[i].Eshterak;
                Result[i].PhoneNubmber = Vooroodi[i].PhoneNubmber;
            }
            
            
            return Result;
        }
        public static CustomerResultModel AddNewCustomerInputModel2CustomerResultModel(AddNewCustomerInputModel Vooroodi)
        {
            var Result = new CustomerResultModel();
            Result.FName = Vooroodi.FName;
            Result.LName = Vooroodi.LName;
            Result.Address = Vooroodi.Address;
            Result.Eshterak = Vooroodi.Eshterak;
            Result.PhoneNubmber = Vooroodi.PhoneNubmber;
            return Result;
        }
    }
}
