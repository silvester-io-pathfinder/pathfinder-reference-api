using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class ActionDetailsBlock : BaseEntity
    {
        public string Text { get; set; } = default!;

        public Guid ActionId { get; set; }
        public Models.Action Action { get; set; } = default!;
    }
}
