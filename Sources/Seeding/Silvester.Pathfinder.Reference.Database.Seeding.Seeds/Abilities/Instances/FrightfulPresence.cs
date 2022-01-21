using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Abilities.Instances
{
    public class FrightfulPresence : Template
    {
        public static readonly Guid ID = Guid.Parse("1f4896f2-3dfb-4754-acc0-48386e7ad2c6");

        protected override Ability GetAbility()
        {
            return new Ability
            {
                Id = ID,
                Name = "Frightful Presence",
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetEffects()
        {
            yield return new TextBlock { Id = Guid.Parse("13febb4a-4192-409a-9c36-1ad6808fed0b"), Text = "A creature that first enters the area must attempt a Will save. Regardless of the result of the saving throw, the creature is temporarily immune to this monster's Frightful Presence for 1 minute." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Aura.ID;
            yield return Traits.Instances.Emotion.ID;
            yield return Traits.Instances.Fear.ID;
            yield return Traits.Instances.Mental.ID;
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("36ea93df-4f64-4320-a928-1cbd720c631d"),
                CriticalSuccess = "The creature is unaffected by the presence.",
                Success = "The creature is frightened 1.",
                Failure = "The creature is frightened 2.",
                CriticalFailure = "The creature is frightened 4."
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e29a0e3f-5385-4405-9fb0-dfc3981c3968"),
                SourceId = Sources.Instances.Bestiary.ID,
                Page = 343
            };
        }
    }
}
