using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Effects.Instances
{
    public class GainSpecificAbilityEffect : Effect
    {
        public string? Range { get; set; }

        public Guid AbilityId { get; set; }
        public Ability Ability { get; set; } = default!;
    }
}
