using Silvester.Pathfinder.Official.Database.Utilities.TimeSpans.Enums;

namespace Silvester.Pathfinder.Official.Database.Utilities.TimeSpans
{
    public class Dice
    {
        public Die Die { get; set; }

        public int Amount { get; set; }

        public override string ToString()
        {
            return string.Format("{0}{1}", Amount, Die);
        }
    }
}
