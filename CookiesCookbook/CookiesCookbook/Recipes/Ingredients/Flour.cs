namespace CookiesCookbook.Recipes.Ingredients
{
    internal abstract class Flour : Ingredient
    {
        public override string PreparationInstructions => $"Sieve. {base.PreparationInstructions}";
    }
}
