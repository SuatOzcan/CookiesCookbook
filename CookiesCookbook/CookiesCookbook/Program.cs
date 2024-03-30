namespace CookiesCookbook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CookiesRecipesApp cookiesRecipesApp = new CookiesRecipesApp(new RecipesRepository(),
                                                                        new RecipesConsoleUserInteraction());
            cookiesRecipesApp.Run();
        }
    }
}