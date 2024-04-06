using static CookiesCookbook.Program;

namespace CookiesCookbook
{
    internal static class StringsRepositorySelector
    { 
        public static IStringsRepository SelectStringsRepository(FileFormat FileFormat)
        {
            switch (FileFormat)
            {
                case FileFormat.Json:
                    return new StringsJSONRepository();
                case FileFormat.Txt:
                    return new StringsTextualRepository();
                default:
                    return new StringsTextualRepository();
            }
        }
    }
}