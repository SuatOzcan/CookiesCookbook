namespace CookiesCookbook.Recipes
{
    internal class Oil : Ingredient
    {
        public override int Id { get; set; } = 6;
        public override string Name { get; set; } = "Oil";
        public override string PreparationInstructions => $"Take half a teaspoon. {base.PreparationInstructions} Add to other ingredients.";
    }
}
