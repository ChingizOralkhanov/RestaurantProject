namespace RestaurantProject.Interfaces.Repositories
{
    public interface ICustomerRepository
    {
        public Task BookTable(Guid id);
        public Task GetCustomer(Guid id);
    }
}
