namespace RestaurantProject.DataLayer.DtoModels
{
    public class Restaraunt : BaseModel
    {
        public string Name { get; set; }
        public List<Food> Foods { get; set; }
        public List<Drink> Drinks { get; set; }
        public List<Table> Tables { get; set; }
        public List<Waiter> Waiters { get; set; }
    }
}
