using CookiesCookbook.Recipes;

namespace CookiesCookbook
{
    internal class RecipesRepository : IRecipesRepository
    {
        public List<Recipe> Read(string filePath)
        {
            return new List<Recipe>() {
                new Recipe( 
                    new List<Ingredient>() 
                         { new WheatFlour(), new Butter(), new Sugar() }),
                new Recipe( 
                    new List<Ingredient>() 
                        {new CocoaPowder(), new Oil(), new Cinnamon() })
            };
        }
    }
}