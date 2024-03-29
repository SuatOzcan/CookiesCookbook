namespace CookiesCookbook
{
    internal abstract class Ingredient : IInstruction
    {
        public abstract int ID { get; set; }
        public abstract string Name { get; set; }
        public abstract string InstructionOfPreparing();
    }
}
