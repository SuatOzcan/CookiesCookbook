namespace CookiesCookbook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileFormat fileFormat = FileFormat.Json;
            IStringsRepository stringsRepository;
            string filePath = "recipes";

            switch (fileFormat)
            {
                case FileFormat.Json:
                    stringsRepository = new StringsJSONRepository();
                    filePath += ".json";
                    break;
                case FileFormat.Txt:
                    stringsRepository = new StringsTextualRepository();
                    filePath += ".txt";
                    break;
                default:
                    stringsRepository = new StringsTextualRepository();
                    filePath = ".txt";
                    break;
            }

            IngredientsRegister ingredientsRegister = new IngredientsRegister();

            CookiesRecipesApp cookiesRecipesApp = new CookiesRecipesApp(
                                                                        new RecipesRepository
                                                                                  (
                                                                                  stringsRepository,
                                                                                  ingredientsRegister
                                                                                  ),
                                                                        new RecipesConsoleUserInteraction
                                                                                  (
                                                                                  ingredientsRegister
                                                                                  )
                                                                        );
            cookiesRecipesApp.Run(filePath);
        }

        public enum FileFormat
        {
            Json,
            Txt
        }
    }
}