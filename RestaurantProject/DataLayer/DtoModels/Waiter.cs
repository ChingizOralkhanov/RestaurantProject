namespace RestaurantProject.DataLayer.DtoModels
{
    public class Waiter : BaseModel
    {
        public int Name { get; set; }
        public Customer Customer { get; set; }
    }
}
