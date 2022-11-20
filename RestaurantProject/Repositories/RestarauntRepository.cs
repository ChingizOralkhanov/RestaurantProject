using Microsoft.EntityFrameworkCore;
using RestaurantProject.DataLayer;
using RestaurantProject.DataLayer.DtoModels;
using RestaurantProject.Interfaces.Repositories;

namespace RestaurantProject.Repositories
{
    public class RestarauntRepository : IRestarauntRepository
    {
        private readonly RestarauntDbContext _context;
        public RestarauntRepository(RestarauntDbContext context)
        {
            _context = context;
        }

        public Task<IEnumerable<Customer>> GetAllCustomers()
        {
             return await _context.Customers.ToListAsync();
        }

        public Task<IEnumerable<Table>> GetAllTables()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Waiter>> GetAllWaiters()
        {
            throw new NotImplementedException();
        }

        public async Task<Restaraunt> GetRestaraunt(Guid id) => 
            await _context.Restaraunts.FirstOrDefaultAsync(x => x.Id == id);
    }
}
