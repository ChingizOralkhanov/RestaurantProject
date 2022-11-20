using AutoMapper;
using RestaurantProject.Interfaces.Repositories;
using RestaurantProject.Interfaces.Services;
using RestaurantProject.ViewModels;

namespace RestaurantProject.Services
{
    public class RestarauntService : IRestarauntService
    {
        private readonly IRestarauntRepository _restarauntRepository;
        private readonly IMapper _mapper;
        public RestarauntService(IRestarauntRepository restarauntRepository, IMapper mapper)
        {
            _restarauntRepository = restarauntRepository;
            _mapper = mapper;
        }

        public async Task<RestarauntViewModel> GetRestaraunt(Guid id)
        {
            var restaraunt =  await _restarauntRepository.GetRestaraunt(id);
            if (restaraunt == null) throw new ArgumentNullException();
            return _mapper.Map<RestarauntViewModel>(restaraunt);
        }
    }
}
