using NpgsqlTypes;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class ConditionCategory : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public ICollection<Condition> Conditions { get; set; } = new List<Condition>();

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }
}
