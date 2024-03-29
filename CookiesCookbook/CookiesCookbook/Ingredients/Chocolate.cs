using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookiesCookbook.Ingredients
{
    internal class Chocolate : Ingredient, IInstruction
    {
        public override int ID { get; set; } = 4;
        public override string Name { get; set; } = "Chocolate";

        public string InstructionOfPreparing()
        {
            return "Melt in awater bath. Add to other ingredients.";
        }
    }
}
