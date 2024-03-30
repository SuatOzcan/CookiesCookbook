using CookiesCookbook.Recipes;
using System.ComponentModel;

namespace CookiesCookbook
{
    internal class RecipesRepository : IRecipesRepository
    {
        private readonly IStringsRepository _stringsRepository;

        public RecipesRepository(IStringsRepository stringsRepository)
        {
            _stringsRepository = stringsRepository;
        }
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

        public void Write(string filePath, List<Recipe> allRecipes)
        {
            List<string> recipesAsStrings= new List<string>();

            foreach (var recipe in allRecipes)
            {
                var allIds = new List<int>();
                foreach (var ingredient in recipe.Ingredients)
                {
                    allIds.Add(ingredient.Id);
                }
                recipesAsStrings.Add(string.Join(",", allIds));
            }
            _stringsRepository.Write(filePath, recipesAsStrings);
        }
    }
}