using CookiesCookbook.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookiesCookbook
{
    internal class Menu
    {
        private const string  ShowIngredients = @"Create a new cookie recipe! Available ingredients are:
                        [B]utter
                        [C]hocolate
                        [Ci]nnamon
                        [Co]coa powder
                        [Coc]onut flour
                        [O]il
                        [S]ugar
                        [W]heat flour
Type exit to save and close.";
 
        private void PrintIngredients()
        {
            Console.WriteLine(ShowIngredients);
        }

        public void MenuLoop(Recipe recipe, Print print)
        {
            bool stillAdding = true;
            PrintIngredients();

            while (stillAdding)
            {
                string userInput = "";
                userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "B":
                        recipe.AddIngredientsToRecipe(new Butter());
                        print.PrintIngredientAddedToRecipe(new Butter());
                        break;
                    case "C":
                        recipe.AddIngredientsToRecipe(new Chocolate());
                        print.PrintIngredientAddedToRecipe(new Chocolate());
                        break;
                    case "Ci":
                        recipe.AddIngredientsToRecipe(new Cinnamon());
                        print.PrintIngredientAddedToRecipe(new Cinnamon());
                        break;
                    case "Co":
                        recipe.AddIngredientsToRecipe(new CocoaPowder());
                        print.PrintIngredientAddedToRecipe(new CocoaPowder());
                        break;
                    case "Coc":
                        recipe.AddIngredientsToRecipe(new CoconutFlour());
                        print.PrintIngredientAddedToRecipe(new CoconutFlour());
                        break;
                    case "O":
                        recipe.AddIngredientsToRecipe(new Oil());
                        print.PrintIngredientAddedToRecipe(new Oil());
                        break;
                    case "S":
                        recipe.AddIngredientsToRecipe(new Sugar());
                        print.PrintIngredientAddedToRecipe(new Sugar());
                        break;
                    case "W":
                        recipe.AddIngredientsToRecipe(new WheatFlour());
                        print.PrintIngredientAddedToRecipe(new WheatFlour());
                        break;
                    case "Exit":
                        stillAdding = false;
                        break;
                    default:
                        Console.WriteLine("Unknown ingredient.");
                        break;
                }

            }
        }


    }
}
