using RestaurantProject.DataLayer.DtoModels;

namespace RestaurantProject.ViewModels
{
    public class CustomerViewModel
    {
        public Guid TableId { get; set; }
        public TableViewModel Table { get; set; }
        public BillViewModel Bill { get; set; }
    }
}
