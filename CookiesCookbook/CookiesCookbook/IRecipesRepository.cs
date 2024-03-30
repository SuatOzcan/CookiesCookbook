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
        List<Recipe> Read(string filePath);
    }
}
