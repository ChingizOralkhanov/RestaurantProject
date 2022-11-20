namespace RestaurantProject.DataLayer.DtoModels
{
    public class Bill : BaseModel
    {
        public decimal Amount { get; set; }
        public List<Food> Foods { get; set; }
        public List<Drink> Drinks { get; set; }
    }
}
