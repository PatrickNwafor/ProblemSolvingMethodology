using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingMethodology
{
    class Card
    {
        public string Face { get; set; }
        public Suit Suit { get; set; }

        public override string ToString()
        {
            string card = "(" + this.Face + " " + this.Suit + ")";
            return card;
        }
    }
}
