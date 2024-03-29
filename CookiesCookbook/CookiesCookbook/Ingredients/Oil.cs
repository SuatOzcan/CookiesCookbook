namespace CookiesCookbook.Ingredients
{
    internal class Oil : Ingredient
    {
        public override int ID { get; set; } = 6;
        public override string Name { get; set; } = "Oil";
        public override string InstructionOfPreparing()
        {
            return "Take half a teaspoon. Add to other ingredients.";
        }
    }
}
