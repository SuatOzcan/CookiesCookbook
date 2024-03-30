using CookiesCookbook.Recipes;

namespace CookiesCookbook.Ingredients
{
    internal class Oil : Ingredient
    {
        public override int Id { get; set; } = 6;
        public override string Name { get; set; } = "Oil";
        public override string PreparationInstruction { get; } = $"Take half a teaspoon. Add to other ingredients.";
    }
}
