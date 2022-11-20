using RestaurantProject.ViewModels;

namespace RestaurantProject.Interfaces.Services
{
    public interface IRestarauntService
    {
        public Task<RestarauntViewModel> GetRestaraunt(Guid id);
    }
}
