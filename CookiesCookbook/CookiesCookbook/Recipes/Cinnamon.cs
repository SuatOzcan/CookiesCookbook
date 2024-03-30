using CookiesCookbook.Recipes;

namespace CookiesCookbook.Ingredients
{
    internal class Cinnamon : Ingredient
    {
        public override int Id { get; set; } = 7;
        public override string Name { get; set; } = "Cinnamon";

        public override string PreparationInstruction  => $"Take half a teaspoon. {base.PreparationInstruction}";

    }
}
