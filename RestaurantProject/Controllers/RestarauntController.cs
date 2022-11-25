using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RestaurantProject.Interfaces.Repositories;
using RestaurantProject.Interfaces.Services;
using RestaurantProject.ViewModels;

namespace RestaurantProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RestarauntController : ControllerBase
    {
        private readonly ILogger<RestarauntController> _logger;
        private readonly IRestarauntService _restarauntService;
        private readonly IMapper _mapper;
        public RestarauntController(ILogger<RestarauntController> logger,
            IRestarauntService restarauntService,
            IMapper mapper)
        {
            _logger = logger;
            _restarauntService = restarauntService;
            _mapper = mapper;
        }

        [HttpGet("GetRestaraunt")]
        public async Task<RestarauntViewModel> GetRestaraunt([FromBody] Guid id)
        {
            return await _restarauntService.GetRestaraunt(id);
        }
    }
}
