namespace RestaurantProject.DataLayer.DtoModels
{
    public class Drink : BaseModel
    {
        public bool IsAlcoholic { get; set; }
        public string Ingredients { get; set; }
        public decimal Price { get; set; }
    }
}
