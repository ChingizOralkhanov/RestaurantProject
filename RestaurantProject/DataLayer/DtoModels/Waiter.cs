namespace RestaurantProject.DataLayer.DtoModels
{
    public class Waiter : BaseModel
    {
        public string Name { get; set; }
        public Customer Customer { get; set; }
    }
}
