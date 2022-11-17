using RestaurantProject.DataLayer.DtoModels.Base;

namespace RestaurantProject.DataLayer.DtoModels.Restaraunt
{
    public class Restaraunt : BaseModel
    {
        public string Name { get; set; }
        public Kitchen Kitchen { get; set; }
        public Bar Bar { get; set; }
        public List<Waiter> Waiters { get; set; }
        public List<Table> Tables { get; set; }
    }
}
