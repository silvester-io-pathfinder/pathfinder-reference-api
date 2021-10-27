using NpgsqlTypes;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
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

        public ICollection<Bloodline> Bloodlines { get; set; } = new List<Bloodline>();

        public ICollection<GunslingersWay> GunslingersWays { get; set; } = new List<GunslingersWay>();

        public ICollection<Eidolon> Eidolons { get; set; } = new List<Eidolon>();

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }
}
