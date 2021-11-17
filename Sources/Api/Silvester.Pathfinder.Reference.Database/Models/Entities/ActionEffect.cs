using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class ActionEffect : BaseEntity
    {
        public Guid OwnerId { get; set; }
        
        public string Name { get; set; } = default!;

        public string? Trigger { get; set; }

        public Guid ActionTypeId { get; set; }
        public ActionType ActionType { get; set; } = default!;

        public ICollection<TextBlock> Effects { get; set; } = new List<TextBlock>();
    }
}
