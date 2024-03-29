using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookiesCookbook.Ingredients
{
    internal class CocoaPowder : Ingredient, IInstruction
    {
        public override int ID { get; set; } = 8;
        public override string Name { get; set; } = "Cocoa Powder";

        public string InstructionOfPreparing()
        {
            return "Add to other ingredients.";
        }
    }
}
