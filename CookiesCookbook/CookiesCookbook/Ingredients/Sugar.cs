using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookiesCookbook.Ingredients
{
    internal class Sugar : Ingredient,IInstruction
    {
        public override int ID { get; set; } = 5;
        public override string Name { get; set; } = "Sugar";

        public string InstructionOfPreparing()
        {
            return "Add to other ingredients.";
        }
    }
}
