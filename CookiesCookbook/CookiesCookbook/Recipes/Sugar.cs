namespace CookiesCookbook.Ingredients
{
    internal class Sugar : Ingredient
    {
        public override int Id { get; set; } = 5;
        public override string Name { get; set; } = "Sugar";

        public override string PreparationInstruction()
        {
            return "Add to other ingredients.";
        }
    }
}
