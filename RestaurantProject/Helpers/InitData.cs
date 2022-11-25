using Microsoft.EntityFrameworkCore;
using RestaurantProject.DataLayer.DtoModels;

namespace RestaurantProject.Helpers
{
    public static class InitData
    {
        public static ModelBuilder SeedRestaraunt(this ModelBuilder modelBuilder)
        {
            var JackWaiter = new Waiter()
            {
                Name = "Jack"
            };
            var SallyWaiter = new Waiter()
            {
                Name = "Sally"
            };
            var JimWaiter = new Waiter()
            {
                Name = "Jim"
            };
            var BobWaiter = new Waiter()
            {
                Name = "Bob"
            };
            var HelenWaiter = new Waiter()
            {
                Name = "Helen"
            };
            var Waiters = new List<Waiter>();
            Waiters.Add(JackWaiter);
            Waiters.Add(SallyWaiter);
            Waiters.Add(JimWaiter);
            Waiters.Add(BobWaiter);
            Waiters.Add(HelenWaiter);
            modelBuilder.Entity<Restaraunt>().HasData(new Restaraunt()
            {
                Name = "Bob's Burgers",
                Foods = new List<Food>()
                {
                    new Food() { Name =  "HUMMUS A TUNE BURGER",
                        Ingredients = "Beef, egg, panko breadcrumbs, salt, pepper, hummus, red bell pepper, arugula",
                        Price = 6},
                     new Food() { Name =  "UNBREAKABLE KIMCHI SCHMIDT",
                        Ingredients = "Beef,salt, pepper, garlic powder, onion powder,scallion kimchi,American cheese, lettuce; bacon,mayo,sesame seed bun",
                        Price = 7},
                    new Food() { Name =  "BLUE IS THE WARMEST",
                        Ingredients = "Vegetarian burger patty, hot sauce, butter, white vinegar, cayenne, white onion, all-purpose flour, milk, bleu cheese, celery, buns, lettuce",
                        Price = 8},
                    new Food() { Name =  "BET IT ALL ON BLACK GARLIC",
                        Ingredients = "Black garlic, mayonnaise, ground beef, baby spinach, salt, black pepper, sriracha, mozzarella cheese, brioche bun",
                        Price = 10},
                },
                Drinks = new List<Drink>()
                {
                    new Drink()
                    {
                        Name = "Coke",
                        IsAlcoholic = false,
                        Price = 3
                    },
                    new Drink()
                    {
                        Name = "Bloody Mary",
                        IsAlcoholic = true,
                        Ingredients = "Vodka, tomato juice, celery, salt, pepper",
                        Price = 5
                    },
                    new Drink()
                    {
                        Name = "Mojito",
                        IsAlcoholic = true,
                        Ingredients = "Rum, mint, lime,sugar, club soda",
                        Price = 6
                    },
                    new Drink()
                    {
                        Name = "Coffee",
                        IsAlcoholic = false,
                        Ingredients = "Coffee, milk, sugar",
                        Price = 4
                    },
                },
                Tables = new List<Table>()
                {
                    new Table()
                    {
                        Waiter = JackWaiter
                    },
                    new Table()
                    {
                        Waiter = SallyWaiter,
                    },
                    new Table()
                    {
                        Waiter = JimWaiter,
                    },
                    new Table()
                    {
                        Waiter = HelenWaiter,
                    },
                    new Table()
                    {
                        Waiter = BobWaiter,
                    },
                    new Table()
                    {

                    },
                    new Table()
                    {

                    },
                    new Table()
                    {

                    },
                    new Table()
                    {

                    },
                    new Table()
                    {

                    },
                    new Table()
                    {

                    },
                    new Table()
                    {

                    },
                    new Table()
                    {

                    },
                    new Table()
                    {

                    },
                    new Table()
                    {

                    },
                    new Table()
                    {

                    },
                    new Table()
                    {

                    },
                    new Table()
                    {

                    },

                },
                Waiters = Waiters,

            });
            return modelBuilder;
        }
    }
}
