using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class SkillAction : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public string? Requirements { get; set; } = default!;

        public Guid ActionTypeId { get; set; }
        public ActionType ActionType { get; set; } = default!;

        public Guid RequiredProficiencyId { get; set; }
        public Proficiency RequireProficiency { get; set; } = default!;

        public Guid SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; } = default!;

        public Guid? RollableEffectId { get; set; }
        public RollableEffect? RollableEffect { get; set; }

        public Guid? TableId { get; set; }
        public Table? Table { get; set; }

        public ICollection<Skill> Skills { get; set; } = new List<Skill>();

        public ICollection<TextBlock> Details { get; set; } = new List<TextBlock>();

        public ICollection<Trait> Traits { get; set; } = new List<Trait>();

        public ICollection<PlayMode> RequiredPlayModes { get; set; } = new List<PlayMode>();

        public ICollection<SkillActionExample> Examples { get; set; } = new List<SkillActionExample>();

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }
}
