using Silvester.Pathfinder.Official.Database;
using System;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class Skill : BaseEntity
    {
        public string Name { get; set; } = default!;

        public bool HasArmorCheckPenalty { get; set; }
        public bool HasRecallKnowledgeAction { get; set; }

        public Guid StatModifierId { get; set; }
        public Stat StatModifier { get; set; } = default!;

    }
}
