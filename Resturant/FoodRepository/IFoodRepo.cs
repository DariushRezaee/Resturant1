using Resturant.ResultModels;

namespace Resturant.FoodRepository
{
    public interface IFoodRepo
    {
        List<FoodResultModel> GetAllFoods();

        FoodResultModel GetOneFoodData(int Id);

        bool AddNewFood(AddNewFoodInputModel model);

        bool UpdateOneFoodData(UpdateOneFoodInputModel model);
    } 
}
