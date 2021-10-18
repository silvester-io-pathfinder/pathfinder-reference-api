using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Effects.Instances
{
    public class ModifySpecificSavingThrowEffect : Effect
    {
        public Guid SavingThrowStatId { get; set; }
        public SavingThrowStat SavingThrowStat { get; set; } = default!;

        public RollResult InitialResult { get; set; }
        public RollResult Becomes { get; set; }
    }
}
