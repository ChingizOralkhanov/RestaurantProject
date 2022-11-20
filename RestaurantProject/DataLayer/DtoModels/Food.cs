namespace RestaurantProject.DataLayer.DtoModels
{
    public class Food : BaseModel
    {
        public string Ingredients { get; set; }
        public decimal Price { get; set; }
    }
}
