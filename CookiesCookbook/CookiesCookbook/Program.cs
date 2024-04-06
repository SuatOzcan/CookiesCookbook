﻿namespace CookiesCookbook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileFormat fileFormat = FileFormat.Txt;
            FileMetaData fileMetaData = new FileMetaData("recipes", fileFormat);
            string filePath = fileMetaData.ToPath();
            IStringsRepository stringsRepository = StringsRepositorySelector.SelectStringsRepository(fileFormat);

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