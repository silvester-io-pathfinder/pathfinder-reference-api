using System;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public enum ConditionDetailBlockType
    {
        Title,
        Text,
        Enumeration
    }

    public class ConditionDetailBlock : BaseEntity
    {
        public string Text { get; set; } = default!;

        public ConditionDetailBlockType Type { get; set; } = default!;

        public Guid ConditionId { get; set; }
        public Condition Condition { get; set; } = default!;
    }
}
