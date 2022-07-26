using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingMethodology.Examples
{
    class Card
    {
        public string Face { get; set; }
        public Suit Suit { get; set; }

        public override string ToString()
        {
            string card = "(" + Face + " " + Suit + ")";
            return card;
        }
    }
}
