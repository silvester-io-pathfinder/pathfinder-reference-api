using NpgsqlTypes;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class SavingThrowStat : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public ICollection<TextBlock> Details { get; set; } = new List<TextBlock>();
     
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }
}
