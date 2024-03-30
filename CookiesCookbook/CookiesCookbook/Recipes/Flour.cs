namespace CookiesCookbook.Recipes
{
    internal abstract class Flour : Ingredient
    {
        public override string PreparationInstructions => $"Sieve. {base.PreparationInstructions}";
    }
}
