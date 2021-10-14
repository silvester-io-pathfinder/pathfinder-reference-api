using NpgsqlTypes;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Models
{
    public class Skill : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;

        public bool HasArmorCheckPenalty { get; set; }
        public bool HasRecallKnowledgeAction { get; set; }

        public Guid StatModifierId { get; set; }
        public Stat StatModifier { get; set; } = default!;

        public ICollection<Deity> Deities { get; set; } = new List<Deity>();

        public ICollection<SkillAction> SkillActions { get; set; } = new List<SkillAction>();

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }
}
