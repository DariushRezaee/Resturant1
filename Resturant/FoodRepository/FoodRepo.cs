using Resturant.CustomerServices;
using Resturant.Db;
using Resturant.DbTables;
using Resturant.FoodServices;
using Resturant.ResultModels;

namespace Resturant.FoodRepository
{
    public class FoodRepo : IFoodRepo
    {
        MyDbContext _db;

        public FoodRepo(MyDbContext db1)
        {
            _db = db1;
        }

        public bool AddNewFood(AddNewFoodInputModel model)
        {
            _db.Food.Add(new Foods()
            {
                FoodName = model.FoodName,
            });
            _db.SaveChanges();
            return true;
        }

        public List<FoodResultModel> GetAllFoods()
        {
            var x = _db.Food.Select(x => new FoodResultModel
            {

                FoodName = x.FoodName,
            }).ToList();
            _db.SaveChanges();
            return x;
        }

        public FoodResultModel GetOneFoodData(int Id)
        {
            var SelectOneFood = _db.Food.FirstOrDefault(x => x.Id == Id);
            var result2 = FoodMapper.ConvertFood2FoodResultModel(SelectOneFood);
            _db.SaveChanges();
            return result2;
        }
        public bool UpdateOneFoodData(UpdateOneFoodInputModel model)
        {
            var UpdateOneFood = _db.Food.FirstOrDefault(x => x.Id == model.Id);
            UpdateOneFood.FoodName = model.FoodName;
            _db.SaveChanges();
            return true;
        }
    }
}
