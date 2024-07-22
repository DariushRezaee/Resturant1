using Resturant.FoodRepository;
using Resturant.ResultModels;

namespace Resturant.FoodServices
{
    public class FoodService : IFoodService
    {
        IFoodRepo _foodRepo;

        public FoodService(IFoodRepo foodRepo)
        {
            _foodRepo = foodRepo;
        }

        public bool AddNewFood(AddNewFoodInputModel model)
        {
            return _foodRepo.AddNewFood(model);

        }

        public List<FoodResultModel> GetAllFoods()
        {
            return _foodRepo.GetAllFoods();
        }

        public FoodResultModel GetOneFoodData(int Id)
        {
            return _foodRepo.GetOneFoodData(Id);
        }

        public bool UpdateOneFoodData(UpdateOneFoodInputModel model)
        {
            if (model.Id == null ||
               model.FoodName == null)
            {
                return false;
            }
            else
            {
                return _foodRepo.UpdateOneFoodData(model);
            }
        }
    }
}
