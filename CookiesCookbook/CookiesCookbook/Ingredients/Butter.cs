namespace CookiesCookbook.Ingredients
{
    internal class Butter : Ingredient
    {
        public override int ID { get; set; } = 3;
        public override string Name { get; set; } = "Butter";
        public override string InstructionOfPreparing()
        {
            return "Melt on low-heat. Add to other ingredients.";
        }
    }
}
