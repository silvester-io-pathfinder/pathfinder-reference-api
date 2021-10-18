using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Effects.Instances
{
    public class ModifyFeatLevelPrerequisiteEffect : Effect
    {
        public Guid FeatId { get; set; }
        public Feat Feat { get; set; } = default!;

        public ModifierType ModifierType { get; set; }
        public int Modifier { get; set; }
    }
}

