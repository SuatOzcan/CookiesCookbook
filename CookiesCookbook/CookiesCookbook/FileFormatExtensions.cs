using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CookiesCookbook.Program;

namespace CookiesCookbook
{
    internal static class FileFormatExtensions
    {
        public static string AsFileExtension(this FileFormat fileFormat)
        {
            switch (fileFormat)
            {
                case FileFormat.Json:
                    return "json";
                case FileFormat.Txt:
                    return "txt";
                default:
                    return "txt";
            }
        }
    }
}
