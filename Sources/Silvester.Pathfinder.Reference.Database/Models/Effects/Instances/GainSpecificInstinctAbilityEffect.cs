using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Effects.Instances
{
    public class GainSpecificInstinctAbilityEffect : Effect
    {
        public Guid InstinctAbilityId { get; set; }
        public InstinctAbility InstinctAbility  { get; set; } = default!;
    }
}
