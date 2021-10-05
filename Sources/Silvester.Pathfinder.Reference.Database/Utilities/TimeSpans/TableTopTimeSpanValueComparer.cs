using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Silvester.Pathfinder.Reference.Database.Utilities.TimeSpans
{
    public class TableTopTimeSpanValueComparer : ValueComparer<TableTopTimeSpan>
    {
        public TableTopTimeSpanValueComparer(bool favorStructuralComparisons)
            : base(favorStructuralComparisons)
        {

        }
    }
}
