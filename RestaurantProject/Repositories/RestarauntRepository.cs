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

        public async Task<Restaraunt> GetRestaraunt(Guid id) => 
            await _context.Restaraunts.FirstOrDefaultAsync(x => x.Id == id);
    }
}
