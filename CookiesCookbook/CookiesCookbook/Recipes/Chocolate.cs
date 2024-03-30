using CookiesCookbook.Recipes;

namespace CookiesCookbook.Ingredients
{
    internal class Chocolate : Ingredient
    {
        public override int Id { get; set; } = 4;
        public override string Name { get; set; } = "Chocolate";

        public override string PreparationInstruction => $"Melt in a water bath. {base.PreparationInstruction}";
        
    }
}
