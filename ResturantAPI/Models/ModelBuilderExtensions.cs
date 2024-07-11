using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;

namespace ResturantAPI.Models

{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Menu>().HasData(
                new Menu { Id = 1, Name = "BreakFast" },
                new Menu { Id = 2, Name = "lunch" },
                new Menu { Id = 3, Name = "Dinner" },
                new Menu { Id = 4, Name = "Dessert" },
                new Menu { Id = 5, Name = "Side Dish" });

            modelBuilder.Entity<Dish>().HasData(
                new Dish { Id = 1, MenuId = 1, Name = "American pancakes", Price = 5000, IsVegetarian = true },
                new Dish { Id = 2, MenuId = 1, Name = "Cheese omelette", Price = 5000, IsVegetarian = false },
                new Dish { Id = 3, MenuId = 1, Name = "Potato fritters", Price = 10000, IsVegetarian = true },
                new Dish { Id = 4, MenuId = 1, Name = "Peanut butter stuffed French toast", Price = 6000, IsVegetarian = true },
                new Dish { Id = 5, MenuId = 1, Name = "Oats", Price = 3500, IsVegetarian = true },
                new Dish { Id = 6, MenuId = 2, Name = "Nigerian Fried rice", Price = 8000, IsVegetarian = true },
                new Dish { Id = 7, MenuId = 2, Name = "Nigerian Jollof rice", Price = 7000, IsVegetarian = true },
                new Dish { Id = 8, MenuId = 2, Name = "Chineese Fried rice", Price = 8000, IsVegetarian = true },
                new Dish { Id = 9, MenuId = 2, Name = "Arabian Rice", Price = 8000, IsVegetarian = true },
                new Dish { Id = 10, MenuId = 2, Name = "Lamb Biryani", Price = 10000, IsVegetarian = false },
                new Dish { Id = 11, MenuId = 3, Name = "Spaghetti and Meat balls", Price = 10000, IsVegetarian = false },
                new Dish { Id = 12, MenuId = 3, Name = "Pizza", Price = 10000, IsVegetarian = true },
                new Dish { Id = 13, MenuId = 3, Name = "Chicken Alfredo", Price = 5000, IsVegetarian = false },
                new Dish { Id = 14, MenuId = 3, Name = "SeaFood boil", Price = 30000, IsVegetarian = false },
                new Dish { Id = 15, MenuId = 3, Name = "Chicken Salad", Price = 5000, IsVegetarian = false },
                new Dish { Id = 16, MenuId = 4, Name = "Tiramisu Layer cake", Price = 10000, IsVegetarian = true },
                new Dish { Id = 17, MenuId = 4, Name = "Lemon Souffles", Price = 10000, IsVegetarian = true },
                new Dish { Id = 18, MenuId = 4, Name = "White Chocolate Chesse cake", Price = 15000, IsVegetarian = true },
                new Dish { Id = 19, MenuId = 4, Name = "Icecream", Price = 5000, IsVegetarian = true },
                new Dish { Id = 20, MenuId = 4, Name = "Waffles and Icecream", Price = 10000, IsVegetarian = true },
                new Dish { Id = 21, MenuId = 5, Name = "Baked Potato", Price = 5000, IsVegetarian = true },
                new Dish { Id = 22, MenuId = 5, Name = "Fries", Price = 3000, IsVegetarian = true },
                new Dish { Id = 23, MenuId = 5, Name = "Potato Salad", Price = 4000, IsVegetarian = true },
                new Dish { Id = 24, MenuId = 5, Name = "Shredded Beef Sauce", Price = 5000, IsVegetarian = false },
                new Dish { Id = 25, MenuId = 5, Name = "Apple Sauce", Price = 5000, IsVegetarian = true });

        }

    }


}








