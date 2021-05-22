using System.Collections.Generic;
using System.Linq;

namespace Silvester.Pathfinder.Official.Database.Utilities.TimeSpans
{
    public class DiceCollection
    {
        public IList<Dice> Dice { get; set; } = new List<Dice>();

        public int? Bonus { get; set; }

        public override string ToString()
        {
            string dice = string.Join(" + ", Dice.Select(e => e.ToString()));

            return Bonus == 0
                ? dice
                : dice + " + " + Bonus;
        }
    }
}
