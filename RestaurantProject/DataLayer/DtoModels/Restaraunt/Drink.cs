using RestaurantProject.DataLayer.DtoModels.Product;

namespace RestaurantProject.DataLayer.DtoModels.Restaraunt
{
    public class Drink : BaseDrink
    {
        public Recipe Recipe { get; set; }
    }
}
