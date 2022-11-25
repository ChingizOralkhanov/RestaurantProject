namespace RestaurantProject.Exceptions
{
    public class EntityNotFoundException : Exception
    {
        public EntityNotFoundException(string entity) : base($@"{entity} does not exist.")
        {
        }
    }
}
