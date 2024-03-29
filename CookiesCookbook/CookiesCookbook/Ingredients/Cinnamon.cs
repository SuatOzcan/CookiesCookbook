using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookiesCookbook.Ingredients
{
    internal class Cinnamon : Ingredient, IInstruction
    {
        public override int ID { get; set; } = 7;
        public override string Name { get; set; } = "Cinnamon";

        public string InstructionOfPreparing()
        {
            return "Take half a teaspoon. Add to other ingredients";
        }
    }
}
