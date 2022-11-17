namespace RestaurantProject.DataLayer.DtoModels.Restaraunt
{
    public class Recipe
    {
        public int Id { get; set; }
        public IEnumerable<string> Ingredients { get; set; }
    }
}
