namespace ResturantAPI.Models
{ 
    public class Menu
    {


        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public virtual List<Dish> Dishes { get; set; }
    }
}




