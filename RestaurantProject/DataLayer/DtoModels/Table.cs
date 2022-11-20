namespace RestaurantProject.DataLayer.DtoModels
{
    public class Table : BaseModel
    {
        public  Waiter Waiter { get; set; }
        public  Customer Customer { get; set; }
    }
}
