using RestaurantProject.DataLayer.DtoModels;

namespace RestaurantProject.ViewModels
{
    public class TableViewModel
    {
        public WaiterViewModel Waiter { get; set; }
        public CustomerViewModel Customer { get; set; }
    }
}
