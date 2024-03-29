namespace CookiesCookbook.Ingredients
{
    internal class Sugar : Ingredient
    {
        public override int ID { get; set; } = 5;
        public override string Name { get; set; } = "Sugar";

        public override string InstructionOfPreparing()
        {
            return "Add to other ingredients.";
        }
    }
}
