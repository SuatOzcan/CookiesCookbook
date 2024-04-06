using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookiesCookbook
{
    internal class StringsTextualRepository : IStringsRepository
    {
        private static readonly string Seperator = Environment.NewLine;

        public List<string> Read(string filePath)
        {
            if(File.Exists(filePath)) 
            {
                var fileContents = File.ReadAllText(filePath);
                return fileContents.Split(Seperator).ToList();
            }
            return new List<string>();
        }

        public void Write(string filePath, List<string> strings)
        {
            File.WriteAllText(filePath, string.Join(Seperator, strings));
        }
    }
}
