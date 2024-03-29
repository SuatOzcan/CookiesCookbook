using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookiesCookbook.Ingredients
{
    internal class Oil : Ingredient, IInstruction
    {
        public override int ID { get; set; } = 6;
        public override string Name { get; set; } = "Oil";
        public string InstructionOfPreparing()
        {
            return "Take half a teaspoon. Add to other ingredients.";
        }
    }
}
