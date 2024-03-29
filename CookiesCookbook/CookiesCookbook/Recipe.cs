namespace CookiesCookbook
{
    internal class Recipe
    {
        public List<int> Ingredients { get; set; } = new List<int>();

        public void AddIngredientsToRecipe(Ingredient ingredient)
        {
            Ingredients.Add(ingredient.ID);
        }
    }
}
