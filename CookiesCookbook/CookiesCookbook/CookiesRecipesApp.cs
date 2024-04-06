using CookiesCookbook.Recipes;

namespace CookiesCookbook
{
    internal class CookiesRecipesApp
    {
        private readonly IRecipesRepository _recipesRepository;
        private readonly IRecipesUserInteraction _recipesUserInteraction;

        public CookiesRecipesApp(IRecipesRepository recipesRepository, IRecipesUserInteraction recipesUserInteraction)
        {
            this._recipesRepository = recipesRepository;
            this._recipesUserInteraction = recipesUserInteraction;
        }

        public void Run(string filePath)
        {
            var allRecipes = _recipesRepository.ReadIntoListOfRecipes(filePath);
            _recipesUserInteraction.PrintExistingRecipes(allRecipes);

            _recipesUserInteraction.PromptToCreateRecipe();

            IEnumerable<Ingredient> ingredients = _recipesUserInteraction.ReadIngredientsFromUser();

            if (ingredients.Count() > 0)
            {
                var recipe = new Recipe(ingredients);
                allRecipes.Add(recipe);
                _recipesRepository.PrepareToWrite(filePath, allRecipes);
                _recipesUserInteraction.ShowMessage("Recipe added:");
                _recipesUserInteraction.ShowMessage(recipe.ToString());
            }
            else
            {
                _recipesUserInteraction.ShowMessage("No ingredients have been selected. Recipe will not be saved.");
            }

            _recipesUserInteraction.Exit();
        }
    }
}