namespace CookiesCookbook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Recipe recipe = new Recipe();
            List<int> listOfInt = new List<int>() { 1,2,3};
            Print print = new Print();
            print.PrintRecipe(listOfInt);
            Menu menu = new Menu();
            menu.MenuLoop(recipe, print);
        }
    }
}