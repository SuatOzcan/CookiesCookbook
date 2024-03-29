namespace CookiesCookbook.Ingredients
{
    internal class Flour : Ingredient
    {
        public override string Name { get; set; }
        public override int ID { get; set; }

        public override string InstructionOfPreparing()
        {
            return "Sieve. Add to other ingredients.";
        }
    }
}
