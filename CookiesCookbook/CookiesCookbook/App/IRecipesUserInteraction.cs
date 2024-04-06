using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookiesCookbook.Recipes;
using CookiesCookbook.Recipes.Ingredients;

namespace CookiesCookbook.App
{
    internal interface IRecipesUserInteraction
    {
        internal void Exit(); // It doesn't matter what protection level we assign here.
                              // When implemented in a class, all  of these methods have to be public.

        internal void ShowMessage(string message);
        internal void PrintExistingRecipes(IEnumerable<Recipe> allRecipes);
        void PromptToCreateRecipe();
        IEnumerable<Ingredient> ReadIngredientsFromUser();
    }
}
