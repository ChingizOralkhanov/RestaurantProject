using Microsoft.EntityFrameworkCore;
using RestaurantProject.DataLayer;
using RestaurantProject.DataLayer.DtoModels;
using RestaurantProject.Interfaces.Repositories;

namespace RestaurantProject.Repositories
{
    public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(AppDbContext context) :base(context)
        {
        }

    }
}
