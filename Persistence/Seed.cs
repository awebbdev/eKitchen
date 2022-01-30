using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if(context.Recipes.Any())
            {
                return;
            }

            var recipes = new List<Recipe>
            {
                new Recipe
                {
                    Title = "Spaghetti",
                    Description = "Spaghetti is a type of food typically made from an unleavened dough of durum wheat flour mixed with water or eggs and formed into long, cylindrical or ovular cakes.",
                    Category = "Italian",
                    Servings = 4,
                    DateAdded = DateTime.Now,
                    DateLastCooked = null,
                    Rating = 5
                },
                new Recipe
                {
                    Title = "Pizza",
                    Description = "Pizza is a savory dish of Italian origin, consisting of a usually round, flattened base of leavened wheat-based dough topped with tomatoes, cheese, and often various other ingredients baked at a high temperature, traditionally in a wood-fired oven.",
                    Category = "Italian",
                    Servings = 4,
                    DateAdded = DateTime.Now,
                    DateLastCooked = null,
                    Rating = 5
                },
                new Recipe
                {
                    Title = "Lasagna",
                    Description = "Lasagna is a type of pasta dish from the Italian cuisine, consisting of a layer of thin unleavened pasta, then a sauce made of a mixture of various ingredients, including eggs, meat, vegetables, and herbs.",
                    Category = "Italian",
                    Servings = 4,
                    DateAdded = DateTime.Now,
                    DateLastCooked = null,
                    Rating = 5
                },
                new Recipe
                {
                    Title = "Risotto",
                    Description = "Risotto is a type of pasta dish from the Italian cuisine, consisting of a layer of thin unleavened pasta, then a sauce made of a mixture of various ingredients, including eggs, meat, vegetables, and herbs.",
                    Category = "Italian",
                    Servings = 4,
                    DateAdded = DateTime.Now,
                    DateLastCooked = null,
                    Rating = 5
                },
                new Recipe
                {
                    Title = "Hamburger",
                    Description = "A hamburger is a sandwich consisting of one or more cooked patties of ground meat, usually beef, placed inside a sliced bread roll or bun.",
                    Category = "American",
                    Servings = 4,
                    DateAdded = DateTime.Now,
                    DateLastCooked = null,
                    Rating = 4
                },
                new Recipe
                {
                    Title = "Hot Dog",
                    Description = "A hot dog is a sandwich consisting of one or more cooked patties of ground meat, usually beef, placed inside a sliced bread roll or bun.",
                    Category = "American",
                    Servings = 4,
                    DateAdded = DateTime.Now,
                    DateLastCooked = null,
                    Rating = 4
                },
                new Recipe
                {
                    Title = "Pancakes",
                    Description = "Pancakes are a type of scrambled eggs, often served in a thick syrup or batter form.",
                    Category = "American",
                    Servings = 4,
                    DateAdded = DateTime.Now,
                    DateLastCooked = null,
                    Rating = 4
                },
                new Recipe
                {
                    Title = "Egg Fried Rice",
                    Description = "Egg fried rice is a dish of cooked rice that is stir-fried in a wok or a frying pan and is usually mixed with other ingredients such as eggs, vegetables, and Chinese or Thai herbs.",
                    Category = "Chinese",
                    Servings = 4,
                    DateAdded = DateTime.Now,
                    DateLastCooked = null,
                    Rating = 5
                },
                new Recipe
                {
                    Title = "Chicken Fried Rice",
                    Description = "Chicken fried rice is a dish of cooked rice that is stir-fried in a wok or a frying pan and is usually mixed with other ingredients such as eggs, vegetables, and Chinese or Thai herbs.",
                    Category = "Chinese",
                    Servings = 4,
                    DateAdded = DateTime.Now,
                    DateLastCooked = null,
                    Rating = 5
                },
                new Recipe
                {
                    Title = "Burritos",
                    Description = "A burrito is a traditional Mexican dish consisting of a tortilla, a filling, and a side dish, wrapped in a flour tortilla.",
                    Category = "Mexican",
                    Servings = 2,
                    DateAdded = DateTime.Now,
                    DateLastCooked = null,
                    Rating = 3
                },
                new Recipe
                {
                    Title = "Tacos",
                    Description = "A taco is a traditional Mexican dish consisting of a corn or flour tortilla folded or rolled around a filling, such as meat, cheese, or vegetables.",
                    Category = "Mexican",
                    Servings = 2,
                    DateAdded = DateTime.Now,
                    DateLastCooked = null,
                    Rating = 4
                }
            };

            await context.Recipes.AddRangeAsync(recipes);
            await context.SaveChangesAsync();
        }
    }
}