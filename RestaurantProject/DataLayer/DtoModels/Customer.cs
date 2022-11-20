
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantProject.DataLayer.DtoModels
{
    public class Customer : BaseModel 
    {
        public Guid TableId { get; set; }
        public Table Table{ get; set; }
        public Bill Bill { get; set; }
    }
}
