namespace CookiesCookbook.Recipes
{
    internal class Butter : Ingredient
    {
        public override int Id { get; set; } = 3;
        public override string Name { get; set; } = "Butter";
        public override string PreparationInstructions => $"Melt on low-heat. {base.PreparationInstructions}";
        //
        // {base.PreparationInstruction} does not work in
        // public override string PreparationInstruction { get; } = "Melt on low-heat. Add to other ingredients.";

    }
}
