using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookiesCookbook.Recipes
{
    internal interface IRecipesRepository
    {
        List<Recipe> ReadIntoListOfRecipes(string filePath);
        void PrepareToWrite(string filePath, List<Recipe> allRecipes);
    }
}
