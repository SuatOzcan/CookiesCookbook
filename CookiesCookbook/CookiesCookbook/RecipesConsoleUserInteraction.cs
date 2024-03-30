using CookiesCookbook.Recipes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookiesCookbook
{
    internal class RecipesConsoleUserInteraction : IRecipesUserInteraction
    {
        private readonly IngredientsRegister _ingredientsRegister;

        public RecipesConsoleUserInteraction(IngredientsRegister ingredientsRegister)
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
            foreach(Ingredient ingredient in _ingredientsRegister.All)
            {
                Console.WriteLine(ingredient);
            }
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
                foreach(Recipe recipe in allRecipes)
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
