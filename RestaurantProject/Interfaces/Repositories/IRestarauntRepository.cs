using RestaurantProject.DataLayer.DtoModels;

namespace RestaurantProject.Interfaces.Repositories
{
    public interface IRestarauntRepository
    {
        public Task<Restaraunt> GetRestaraunt(Guid Id);
        public Task<IEnumerable<Table>> GetAllTables();
        public Task<IEnumerable<Waiter>> GetAllWaiters();
        public Task<IEnumerable<Customer>> GetAllCustomers();
    }
}
