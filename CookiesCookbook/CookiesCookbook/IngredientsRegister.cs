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

        internal Ingredient GetById(int id)
        {
            foreach (var ingredient in All)
            {
                if(ingredient.Id == id)
                {
                    return ingredient;
                }
            }
            return null;
        }
    }
}