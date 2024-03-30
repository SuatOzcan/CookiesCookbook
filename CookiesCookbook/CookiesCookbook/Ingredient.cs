namespace CookiesCookbook
{
    internal abstract class Ingredient
    {
        public abstract int ID { get; set; }
        public abstract string Name { get; set; }
        public abstract string InstructionOfPreparing();

        public Ingredient(int id, string name)
        {
            ID = id;
            Name = name;
        }

        public Ingredient() { }
    }
}
