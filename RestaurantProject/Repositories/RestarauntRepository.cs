using Microsoft.EntityFrameworkCore;
using RestaurantProject.DataLayer;
using RestaurantProject.DataLayer.DtoModels;
using RestaurantProject.Interfaces.Repositories;

namespace RestaurantProject.Repositories
{
    public class RestarauntRepository :BaseRepository<Restaraunt>,  IRestarauntRepository
    {
        public RestarauntRepository(AppDbContext context) : base(context)
        {
        }

    }
}
