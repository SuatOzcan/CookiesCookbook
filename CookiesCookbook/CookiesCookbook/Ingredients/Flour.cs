using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookiesCookbook
{
    internal class Flour : Ingredient, IInstruction
    {
        public override string Name { get ; set ; }
        public override int ID { get; set; }

        public string InstructionOfPreparing()
        {
            return "Sieve. Add to other ingredients.";
        }
    }
}
