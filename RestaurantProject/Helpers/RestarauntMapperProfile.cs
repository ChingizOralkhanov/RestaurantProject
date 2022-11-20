using AutoMapper;
using RestaurantProject.DataLayer.DtoModels;
using RestaurantProject.ViewModels;

namespace RestaurantProject.Helpers
{
    public class RestarauntMapperProfile : Profile
    {
        public RestarauntMapperProfile()
        {
            CreateMap<Bill, BillViewModel>();
            CreateMap<Customer, CustomerViewModel>();
            CreateMap<Drink, DrinkViewModel>();
            CreateMap<Food, FoodViewModel>();
            CreateMap<Restaraunt, RestarauntViewModel>();
            CreateMap<Table, TableViewModel>();
            CreateMap<Waiter, WaiterViewModel>();
        }
    }
}
