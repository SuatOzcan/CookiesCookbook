namespace CookiesCookbook.Ingredients
{
    internal class CocoaPowder : Ingredient
    {
        public override int ID { get; set; } = 8;
        public override string Name { get; set; } = "Cocoa Powder";

        public override string InstructionOfPreparing()
        {
            return "Add to other ingredients.";
        }
    }
}
