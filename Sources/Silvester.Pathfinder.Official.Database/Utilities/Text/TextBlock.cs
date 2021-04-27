using System;

namespace Silvester.Pathfinder.Official.Database.Utilities.Text
{
    public class TextBlock : BaseEntity, IOwnedEntity
    {
        public string Text { get; set; } = default!;

        public int Order { get; set; }

        public TextBlockType Type { get; set; } 

        public Guid OwnerId { get; set; }
    }
}
