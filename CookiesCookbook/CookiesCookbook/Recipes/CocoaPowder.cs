namespace CookiesCookbook.Ingredients
{
    internal class CocoaPowder : Ingredient
    {
        public override int Id { get; set; } = 8;
        public override string Name { get; set; } = "Cocoa Powder";

        public override string PreparationInstruction()
        {
            return "Add to other ingredients.";
        }
    }
}
