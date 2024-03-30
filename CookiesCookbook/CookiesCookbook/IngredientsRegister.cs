using CookiesCookbook.Recipes;

namespace CookiesCookbook
{
    internal class IngredientsRegister
    {
        public IEnumerable<Ingredient> All { get; } = new List<Ingredient> { 
        new Butter(),
        new Chocolate(),
        new Cinnamon(),
        new CocoaPowder(),
        new CoconutFlour(),
        new Oil(),
        new Sugar(),
        new WheatFlour()}; 
    }
}