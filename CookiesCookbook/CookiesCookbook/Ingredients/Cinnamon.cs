namespace CookiesCookbook.Ingredients
{
    internal class Cinnamon : Ingredient
    {
        public override int ID { get; set; } = 7;
        public override string Name { get; set; } = "Cinnamon";

        public override string InstructionOfPreparing()
        {
            return "Take half a teaspoon. Add to other ingredients";
        }
    }
}
