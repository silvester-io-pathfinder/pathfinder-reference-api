using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class Condition : BaseEntity
    {
        public string Name { get; set; } = default!;
     
        public Guid? SourcePageId { get; set; }
        public SourcePage? SourcePage { get; set; } = default!;

        public Guid? ConditionCategoryId { get; set; }
        public ConditionCategory? ConditionCategory { get; set; } = default!;

        public Guid? OverridesConditionId { get; set; }
        public Condition? OverridesCondition { get; set; }

        public ICollection<TextBlock> Details { get; set; } = new List<TextBlock>();
    }
}
