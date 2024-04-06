namespace CookiesCookbook.Recipes.Ingredients
{
    internal class Chocolate : Ingredient
    {
        public override int Id { get; set; } = 4;
        public override string Name { get; set; } = "Chocolate";

        public override string PreparationInstructions => $"Melt in a water bath. {base.PreparationInstructions}";

    }
}
