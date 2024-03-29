using CookiesCookbook.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookiesCookbook
{
    internal class Print
    {
        public List<Ingredient> Ingredients = new List<Ingredient>();

        public Print() {
            AddAllIngredientsToList();
         }

        private void AddAllIngredientsToList()
        {
            Ingredients.Add(new Butter());
            Ingredients.Add(new Chocolate());
            Ingredients.Add(new Cinnamon());
            Ingredients.Add(new CocoaPowder());
            Ingredients.Add(new CoconutFlour());
            Ingredients.Add(new Oil());
            Ingredients.Add(new Sugar());
            Ingredients.Add(new WheatFlour());
        }
        public void PrintRecipe(List<int> listOfIngredients) // This will be IDs.
        {
            foreach (int ingredientID in listOfIngredients)
            {
                foreach (Ingredient ingredient in Ingredients)
                {
                    if (ingredient.ID == ingredientID)
                    {
                        Console.WriteLine(ingredient.Name + ingredient.InstructionOfPreparing());
                    }
                }
            }
        }

        public void PrintIngredientAddedToRecipe(Ingredient ingredient)
        {
            Console.WriteLine(ingredient.Name + " has been added to the recipe.");
        }
    }
}
