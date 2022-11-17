using RestaurantProject.DataLayer.Enums;

namespace RestaurantProject.DataLayer.DtoModels.Product
{
    public abstract class BaseDrink
    {
        public int Id { get; set; }
        public bool IsAlcoholic { get; set; }
        public DrinkCategory DrinkCategory { get; set; }
    }
}
