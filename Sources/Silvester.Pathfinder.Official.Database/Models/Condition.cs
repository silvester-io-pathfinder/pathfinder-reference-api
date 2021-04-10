using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class Condition : BaseEntity
    {
        public string Name { get; set; } = default!;
     
        public string Description{ get; set; } = default!;
        
        public Guid? SourcePageId { get; set; }
        public Source? SourcePage { get; set; } = default!;

        public Guid? ConditionCategoryId { get; set; }
        public ConditionCategory? ConditionCategory { get; set; } = default!;

        public Guid? OverridesConditionId { get; set; }
        public Condition? OverridesCondition { get; set; }

        public ICollection<ConditionDetailBlock> Details { get; set; } = new List<ConditionDetailBlock>();
    }
}
