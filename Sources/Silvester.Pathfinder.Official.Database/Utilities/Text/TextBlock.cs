using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Utilities.Text
{
    public class TextBlock : BaseEntity
    {
        public string Text { get; set; } = default!;

        public int Order { get; set; }

        public TextBlockType Type { get; set; } 

        public Guid OwnerId { get; set; }
    }
}
