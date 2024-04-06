namespace CookiesCookbook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IngredientsRegister ingredientsRegister = new IngredientsRegister();

            CookiesRecipesApp cookiesRecipesApp = new CookiesRecipesApp(new RecipesRepository(
                                                                          new StringsJSONRepository(),
                                                                          ingredientsRegister),
                                                                        new RecipesConsoleUserInteraction(
                                                                            ingredientsRegister
                                                                            )
                                                                        );
            cookiesRecipesApp.Run("recipes.json");
        }
    }
}