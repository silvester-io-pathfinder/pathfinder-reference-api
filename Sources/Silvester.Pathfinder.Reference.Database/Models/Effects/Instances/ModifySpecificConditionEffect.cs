using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Effects.Instances
{
    public class ModifySpecificConditionEffect : Effect
    {
        public Guid ConditionId { get; set; }
        public Condition Condition { get; set; } = default!;

        public int Modifier { get; set; }
        public ModifierType ModifierType { get; set; }
    }
}
