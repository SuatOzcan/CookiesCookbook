using CookiesCookbook.Recipes;
using CookiesCookbook.Recipes.Ingredients;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookiesCookbook.App
{
    internal class RecipesConsoleUserInteraction : IRecipesUserInteraction
    {
        private readonly IIngredientsRegister _ingredientsRegister;

        public RecipesConsoleUserInteraction(IIngredientsRegister ingredientsRegister)
        {
            _ingredientsRegister = ingredientsRegister;
        }
        public void Exit()
        {
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        public void PromptToCreateRecipe()
        {
            Console.WriteLine("Create a new cookie receipt! Available ingredients are: ");
            foreach (Ingredient ingredient in _ingredientsRegister.All)
            {
                Console.WriteLine(ingredient);
            }
        }

        public IEnumerable<Ingredient> ReadIngredientsFromUser()
        {
            bool shallStop = false;
            List<Ingredient> ingredients = new List<Ingredient>();

            while (!shallStop)
            {
                Console.WriteLine("Add an ingredient by its ID, or type anything else if finished.");
                string userInput = Console.ReadLine();
                if (int.TryParse(userInput, out int id))
                {
                    Ingredient selectedIngredient = _ingredientsRegister.GetById(id);
                    if (selectedIngredient != null)
                    {
                        ingredients.Add(selectedIngredient);
                    }
                    else
                    {
                        Console.WriteLine("We do not have the requested ingredient.");
                    }
                }
                else
                {
                    shallStop = true;
                }
            }

            return ingredients;
        }

        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }

        void IRecipesUserInteraction.PrintExistingRecipes(IEnumerable<Recipe> allRecipes)
        {
            if (allRecipes.Count() > 0)
            {
                Console.WriteLine("Existing recipes are: " + Environment.NewLine);
                int counter = 1;
                foreach (Recipe recipe in allRecipes)
                {
                    Console.WriteLine($"****************{counter}****************");
                    Console.WriteLine(recipe);
                    Console.WriteLine();
                    counter++;
                }
            }
        }
    }
}
