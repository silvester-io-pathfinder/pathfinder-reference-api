using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Abilities.Instances
{
    public class TroopDefenses : Template
    {
        public static readonly Guid ID = Guid.Parse("22f4fcc6-63a1-483f-976b-c97e37e9c781");

        protected override Ability GetAbility()
        {
            return new Ability
            {
                Id = ID,
                Name = "Troop Defenses",
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetEffects()
        {
            yield return new TextBlock { Id = Guid.Parse("5b78c823-fed4-4daf-87c4-41117c35a214"), Text = "Troops are composed of many individuals, and over the course of enough attacks and downed comrades, troops shrink in size. Most troops start with 16 squares (4 by 4), and their Hit Points have two listed thresholds, typically the first is at 2/3 their maximum Hit Points and the second is at 1/3 their maximum Hit Points. Once the troop drops below the first threshold, it loses 4 squares, leaving 12 squares remaining, and the first threshold becomes the troop's new maximum Hit Points. Once the troop falls below the second threshold, it loses another 4 squares, leaving 8 squares remaining, and the second threshold becomes the troop's new maximum Hit Points. In order to restore its size and maximum Hit Points, a troop needs to spend downtime to use long-term treatment on casualties or recruit new members to replace the fallen. At 0 Hit Points, the troop is reduced down to 4 squares, which is too few to sustain the troop, so it disperses entirely, with the few remaining members surrendering, fleeing, or easily dispatched, depending on their nature." };
            yield return new TextBlock { Id = Guid.Parse("93d0e46a-009c-4ad5-b873-84bc856e45e0"), Text = "A damaging single-target effect, such as a Strike, can't force a troop to pass through more than one threshold at once. For instance, if a troop had 60 Hit Points, with thresholds at 40 and 20, a Strike for 50 damage would leave the troop at 21 Hit Points, just above the second threshold. A damaging area effect or multi-target effect can cross multiple thresholds at once and could potentially destroy the entire troop in one shot." };
            yield return new TextBlock { Id = Guid.Parse("0395a69c-ea6d-4592-a4ba-3f13f1f8aa22"), Text = "Non-damaging effects with an area or that target all creatures in a certain proximity affect a troop normally if they affect the entire area occupied by the troop. If an effect has a smaller area or numbers of targets, it typically has no effect on the troop. However, if the effect can target at least four creatures or cover at least four squares in the troop, and if it would prevent its targets from acting, cause them to flee, or otherwise make them unable to function as part of the troop for a round or more, the troop loses loses a number of Hit Points equal to the amount required to bring it to the next threshold, removing 4 squares. If an effect would both deal damage and automatically cross a threshold due to incapacitating some of the creatures in the troop, apply the damage first. If the damage wasn't enough to cross a threshold on its own, then reduce the Hit Points to cross the threshold for the incapacitating effect." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cb0323a1-3e41-437e-a0db-721d79ba4c07"),
                SourceId = Sources.Instances.Bestiary3.ID,
                Page = 306
            };
        }
    }
}
