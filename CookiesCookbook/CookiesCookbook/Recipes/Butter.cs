using CookiesCookbook.Recipes;

namespace CookiesCookbook.Ingredients
{
    internal class Butter : Ingredient
    {
        public override int Id { get; set; } = 3;
        public override string Name { get; set; } = "Butter";
        public override string PreparationInstruction => $"Melt on low-heat. {base.PreparationInstruction}";
        //
        // {base.PreparationInstruction} does not work in
        // public override string PreparationInstruction { get; } = "Melt on low-heat. Add to other ingredients.";

    }
}
