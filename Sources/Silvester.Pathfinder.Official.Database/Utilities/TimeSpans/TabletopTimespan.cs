using Silvester.Pathfinder.Official.Database.Utilities.TimeSpans.Enums;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Utilities.TimeSpans
{
    public abstract class TableTopTimeSpan
    {
        //2d4  + 1d6 + 5
        //7
        //1d4
        //%DateTime%
    }

    public class StaticTimeSpan : TableTopTimeSpan
    {
        public TimeSpan TimeSpan { get; set; }

        public override string ToString()
        {
            return TimeSpan.ToString();
        }
    }

    public class DiceTimeSpan : TableTopTimeSpan
    {
        public DiceCollection DiceCollection { get; set; } = new DiceCollection();

        public TimeUnit TimeUnit { get; set; }

        public override string ToString()
        {
            return DiceCollection.ToString() + " " + TimeUnit.ToString();
        }
    }
}
