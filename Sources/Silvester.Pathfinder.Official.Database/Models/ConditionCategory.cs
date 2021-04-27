using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class ConditionCategory : BaseEntity
    {
        public string Name { get; set; } = default!;

        public ICollection<Condition> Conditions { get; set; } = new List<Condition>();
    }
}
