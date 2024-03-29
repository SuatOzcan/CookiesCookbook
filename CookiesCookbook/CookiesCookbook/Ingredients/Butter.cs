using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookiesCookbook.Ingredients
{
    internal class Butter : Ingredient, IInstruction
    {
        public override int ID { get; set; } = 3;
        public override string Name { get; set; } = "Butter";
        public string InstructionOfPreparing()
        {
            return "Melt on lowheat. Add to other ingredients.";
        }
    }
}
