namespace CookiesCookbook.Ingredients
{
    internal class Oil : Ingredient
    {
        public Oil(int id, string name) : base(id, name)
        {
        }
        public Oil() { }

        public override int ID { get; set; } = 6;
        public override string Name { get; set; } = "Oil";
        public override string InstructionOfPreparing()
        {
            return $"Take half a teaspoon. Add to other ingredients.";
        }

        
    }
}
