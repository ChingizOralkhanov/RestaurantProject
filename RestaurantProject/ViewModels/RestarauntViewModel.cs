using RestaurantProject.DataLayer.DtoModels;

namespace RestaurantProject.ViewModels
{
    public class RestarauntViewModel
    {
        public string Name { get; set; }
        public List<FoodViewModel> Foods { get; set; }
        public List<DrinkViewModel> Drinks { get; set; }
        public List<TableViewModel> Tables { get; set; }
        public List<WaiterViewModel> Waiters { get; set; }
    }
}
