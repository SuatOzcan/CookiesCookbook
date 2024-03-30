namespace CookiesCookbook.Recipes
{
    internal class Cinnamon : Ingredient
    {
        public override int Id { get; set; } = 7;
        public override string Name { get; set; } = "Cinnamon";

        public override string PreparationInstructions => $"Take half a teaspoon. {base.PreparationInstructions}";

    }
}
