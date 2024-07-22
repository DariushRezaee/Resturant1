using Resturant.ResultModels;

namespace Resturant.FoodServices
{
    public interface IFoodService
    {
        List<FoodResultModel> GetAllFoods();

        FoodResultModel GetOneFoodData(int Id);

        bool AddNewFood(AddNewFoodInputModel model);

        bool UpdateOneFoodData(UpdateOneFoodInputModel model);
    }
}
