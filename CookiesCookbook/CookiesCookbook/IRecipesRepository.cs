using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookiesCookbook.Recipes;

namespace CookiesCookbook
{
    internal interface IRecipesRepository
    {
        List<Recipe> ReadIntoListOfRecipes(string filePath);
        void PrepareToWrite(string filePath, List<Recipe> allRecipes);
    }
}
