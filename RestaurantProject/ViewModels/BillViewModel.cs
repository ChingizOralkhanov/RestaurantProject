using RestaurantProject.DataLayer.DtoModels;

namespace RestaurantProject.ViewModels
{
    public class BillViewModel
    {
        public decimal Amount { get; set; }
        public List<FoodViewModel> Foods { get; set; }
        public List<DrinkViewModel> Drinks { get; set; }
    }
}
