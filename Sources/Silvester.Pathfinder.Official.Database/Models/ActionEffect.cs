using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Models
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
