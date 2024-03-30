using CookiesCookbook.Recipes;

namespace CookiesCookbook.Ingredients
{
    internal abstract class Flour : Ingredient
    {
        public override string PreparationInstruction  => $"Sieve. {base.PreparationInstruction}";
    }
}
