namespace CookiesCookbook.Recipes
{
    internal abstract class Ingredient
    {
        public abstract int Id { get; set; }
        public abstract string Name { get; set; }
        public virtual string PreparationInstructions { get; } = "Add to other ingredients.";
        // public virtual string PreparationInstruction => "Add other ingredients.";

        public override string ToString()
        {
            return this.Name;
        }
    }
}
