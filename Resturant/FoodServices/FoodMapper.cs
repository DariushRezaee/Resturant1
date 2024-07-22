using Resturant.DbTables;
using Resturant.ResultModels;

namespace Resturant.FoodServices
{
    public static class FoodMapper
    {
        public static FoodResultModel ConvertFood2FoodResultModel(Foods Vooroodi)
        {
            var Result = new FoodResultModel();
            Result.FoodName = Vooroodi.FoodName;
            return Result;
        }
    }
}
