using Newtonsoft.Json;
using System.Text;

namespace RestaurantProject.Helpers
{
    public static class Helpers
    {
        public static StringContent GetSerializedObject(object data)
        {
            var json = JsonConvert.SerializeObject(data);

            return new StringContent(json, Encoding.UTF8, "application/json");
        }
    }
}
