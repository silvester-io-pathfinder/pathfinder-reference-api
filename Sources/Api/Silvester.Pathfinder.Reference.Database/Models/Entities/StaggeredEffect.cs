using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class StaggeredEffect : BaseEntity
    {
        public string? Addendum{ get; set; }

        public int? Level { get; set; }

        public string Onset { get; set; } = default!;

        public string Name { get; set; } = default!;

        public int? DifficultyCheck { get; set; }

        public string MaximumDuration { get; set; } = default!;
        
        public Guid SavingThrowStatId { get; set; }
        public SavingThrowStat SavingThrowStat { get; set; } = default!;

        public ICollection<StaggeredEffectStage> Stages { get; set; } = new List<StaggeredEffectStage>();
        public ICollection<StaggeredEffectTraitBinding> Traits { get; set; } = new List<StaggeredEffectTraitBinding>();

        public Guid OwnerId { get; set; }
    }

    public class StaggeredEffectTraitBinding : TraitBinding<StaggeredEffect>
    {

    }
}
