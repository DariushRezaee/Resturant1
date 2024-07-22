using Microsoft.AspNetCore.Mvc;
using Resturant.CustomerServices;
using Resturant.FoodServices;
using Resturant.ResultModels;
using System.Data;

namespace Resturant.Controllers
{
    public class FoodController : ControllerBase
    {
        IFoodService _foodService;

        public FoodController(IFoodService foodService)
        {
            _foodService = foodService;
        }
        [HttpGet]
        [Route("GetAllFoods")]
        public List<FoodResultModel>GetAllFoods()
        {
            return null;
        }

        [HttpGet]
        [Route("AddNewFood")]
        public bool AddNewFood(AddNewFoodInputModel model)
        {
            return true;
        }

        [HttpGet]
        [Route("GetOneFoodData")]
        public FoodResultModel GetOneFoodData(int Id)
        {
            return null;
        }

        [HttpGet]
        [Route("UpdateOneFoodData")]
        public bool UpdateOneFoodData(UpdateOneFoodInputModel model)
        {
            return true;
        }


    }
}
