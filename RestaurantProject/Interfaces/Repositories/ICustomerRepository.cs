using RestaurantProject.DataLayer.DtoModels;

namespace RestaurantProject.Interfaces.Repositories
{
    public interface ICustomerRepository
    {
        public Task BookTable(Guid tableId, Guid customerId);
        public Task<Customer> GetCustomer(Guid id);
    }
}
