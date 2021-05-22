using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Silvester.Pathfinder.Official.Database.Utilities.TimeSpans
{
    public class TableTopTimeSpanValueComparer : ValueComparer<TableTopTimeSpan>
    {
        public TableTopTimeSpanValueComparer(bool favorStructuralComparisons)
            : base(favorStructuralComparisons)
        {

        }
    }
}
