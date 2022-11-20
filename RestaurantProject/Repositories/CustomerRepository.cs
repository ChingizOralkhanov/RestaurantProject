using Microsoft.EntityFrameworkCore;
using RestaurantProject.DataLayer;
using RestaurantProject.DataLayer.DtoModels;
using RestaurantProject.Interfaces.Repositories;

namespace RestaurantProject.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly RestarauntDbContext _context;
        public CustomerRepository(RestarauntDbContext context)
        {
            _context = context;
        }

        public async Task BookTable(Guid tableId, Guid customerId)
        {
            var table = await _context.Tables.FirstOrDefaultAsync(x => x.Id == tableId);
            var customer = await _context.Customers.FirstOrDefaultAsync(x => x.Id == customerId);
            table.Customer = customer;
            _context.Update(table);
            await _context.SaveChangesAsync();
        }

        public async Task<Customer> GetCustomer(Guid id)
        {
            return await _context.Customers.FirstOrDefaultAsync(x => x.id == id);
        }
    }
}
