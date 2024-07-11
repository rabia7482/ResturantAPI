
using System.Text.Json.Serialization;
namespace ResturantAPI.Models
{
    public class Dish
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;
        

        public decimal Price { get; set; }
        public bool IsVegetarian { get; set; }

        public int MenuId { get; set; }
        [JsonIgnore]
        public virtual Menu? Menu { get; set; }

    }
}




