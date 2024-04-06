using CookiesCookbook.Recipes;

namespace CookiesCookbook
{
    internal interface IIngredientsRegister
    {
        IEnumerable<Ingredient> All { get; }
        Ingredient GetById(int id);
    }
}