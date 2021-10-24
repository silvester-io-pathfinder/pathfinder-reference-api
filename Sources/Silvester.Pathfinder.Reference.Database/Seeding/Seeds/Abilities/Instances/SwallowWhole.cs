using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Abilities.Instances
{
    public class SwallowWhole : Template
    {
        public static readonly Guid ID = Guid.Parse("836fe3f7-70e6-416a-be6f-7f1f505d9fd2");

        protected override Ability GetAbility()
        {
            return new Ability
            {
                Id = ID,
                Name = "Swallow Whole",
                ActionTypeId = ActionTypes.Instances.OneAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetEffects()
        {
            yield return new TextBlock { Id = Guid.Parse("a16e94b7-15b7-4c09-9d01-d74dbb6db334"), Text = "The monster attempts to swallow a creature of the listed size or smaller that it has grabbed in its jaws or mouth. If a swallowed creature is of the maximum size listed, the monster can't use Swallow Whole again. If the creature is smaller than the maximum, the monster can usually swallow more creatures; the GM determines the maximum. The monster attempts an Athletics check opposed by the grabbed creature's Reflex DC. If it succeeds, it swallows the creature. The monster's mouth or jaws no longer grab a creature it has swallowed, so the monster is free to use them to Strike or Grab once again. The monster can't attack creatures it has swallowed." };
            yield return new TextBlock { Id = Guid.Parse("360f21c5-f178-4148-8cec-8b9b52cdc0b5"), Text = "A swallowed creature is grabbed, is slowed 1, and has to hold its breath or start suffocating. The swallowed creature takes the listed amount of damage when first swallowed and at the end of each of its turns while it's swallowed. If the victim Escapes this ability's grabbed condition, it exits through the monster's mouth. This frees any other creature grabbed in the monster's mouth or jaws. A swallowed creature can attack the monster that has swallowed it, but only with unarmed attacks or with weapons of light Bulk or less. The engulfing creature is flat-footed against the attack. If the monster takes piercing or slashing damage equaling or exceeding the listed Rupture value from a single attack or spell, the engulfed creature cuts itself free. A creature that gets free by either Escaping or cutting itself free can immediately breathe and exits the swallowing monster's space." };
            yield return new TextBlock { Id = Guid.Parse("4867b173-2298-4938-bf77-e61413057594"), Text = "If the monster dies, a swallowed creature can be freed by creatures adjacent to the corpse if they spend a combined total of 3 actions cutting the monster open with a weapon or unarmed attack that deals piercing or slashing damage." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Attack.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1f095830-8b0a-43e0-9b91-ebb08f1d6f46"),
                SourceId = Sources.Instances.Bestiary.ID,
                Page = 344
            };
        }
    }
}
