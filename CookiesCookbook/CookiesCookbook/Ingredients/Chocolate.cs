namespace CookiesCookbook.Ingredients
{
    internal class Chocolate : Ingredient
    {
        public override int ID { get; set; } = 4;
        public override string Name { get; set; } = "Chocolate";

        public override string InstructionOfPreparing()
        {
            return "Melt in a water bath. Add to other ingredients.";
        }
    }
}
