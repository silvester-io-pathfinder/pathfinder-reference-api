using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Models
{
    public class Feat : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public bool CanBeLearnedMoreThanOnce { get; set; }

        public string? Special { get; set; } = default!;

        public string? Trigger { get; set; } = default!;

        public string? Frequency { get; set; }

        public string? Requirements { get; set; }

        public int Level { get; set; }

        public Guid ActionTypeId { get; set; }
        public ActionType ActionType { get; set; } = default!;

        public Guid? RollableEffectId { get; set; }
        public RollableEffect? RollableEffect { get; set; }

        public Guid SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; } = default!;

        public ICollection<TextBlock> Details { get; set; } = new List<TextBlock>();

        public ICollection<FeatEffectBinding> CharacterEffects { get; set; } = new List<FeatEffectBinding>();

        public ICollection<FeatPrerequisiteBinding> Prerequisites { get; set; } = new List<FeatPrerequisiteBinding>();

        public ICollection<Trait> Traits { get; set; } = new List<Trait>();

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }
}
