namespace RestaurantProject.DataLayer.DtoModels.Restaraunt
{
    public class Waiter
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsAvailable { get; set; }
        public IEnumerable<Table> Tables;
    }
}
