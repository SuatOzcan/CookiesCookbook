using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookiesCookbook
{
    internal class RecipesConsoleUserInteraction : IRecipesUserInteraction
    {
        public void Exit()
        {
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
