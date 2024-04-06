using CookiesCookbook.Recipes;
using System.ComponentModel;

namespace CookiesCookbook
{
    internal class RecipesRepository : IRecipesRepository
    {
        private const string Seperator = ",";
        private readonly IStringsRepository _stringsRepository;
        private readonly IIngredientsRegister _ingredientsRegister;

        public RecipesRepository(IStringsRepository stringsRepository, IIngredientsRegister ingredientsRegister)
        {
            _stringsRepository = stringsRepository;
            _ingredientsRegister = ingredientsRegister;
        }
        public List<Recipe> ReadIntoListOfRecipes(string filePath)
        {
            //return new List<Recipe>() {
            //    new Recipe( 
            //        new List<Ingredient>() 
            //             { new WheatFlour(), new Butter(), new Sugar() }),
            //    new Recipe( 
            //        new List<Ingredient>() 
            //            {new CocoaPowder(), new Oil(), new Cinnamon() })
            //};

            List<string> recipesFromFile = _stringsRepository.Read(filePath);
            List<Recipe> recipes = new List<Recipe>();

            foreach (var recipeReadedFromFile in recipesFromFile)
            {
                var recipe = RecipeFromString(recipeReadedFromFile);
                recipes.Add(recipe);
            }
            return recipes;
        }

        private Recipe RecipeFromString(string recipeReadedFromFile)
        {
            string[] textualIDs = recipeReadedFromFile.Split(Seperator);
            List<Ingredient> ingredients = new List<Ingredient>();

            foreach (var textualID in textualIDs)
            {
                var id = int.Parse(textualID);
                var ingredient = _ingredientsRegister.GetById(id);
                ingredients.Add(ingredient);
            }

            return new Recipe(ingredients);
        }

        public void PrepareToWrite(string filePath, List<Recipe> allRecipes)
        {
            var recipesAsStrings = new List<string>();
            foreach (var recipe in allRecipes)
            {
                List<int> allIDs = new List<int>();
                foreach(var ingredient in recipe.Ingredients)
                {
                    allIDs.Add(ingredient.Id);
                }
                recipesAsStrings.Add(string.Join(Seperator, allIDs));
            }
            _stringsRepository.Write(filePath, recipesAsStrings);
        }
    }
}