using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.ActionTypes.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Actions.Instances
{
    public class Escape : Template
    {
        public static readonly Guid ID = Guid.Parse("c2bcb0d1-7feb-4f52-8046-d630a6c8f09f");

        protected override Models.Action GetAction()
        {
            return new Models.Action
            {
                Id = ID,
                Name = "Escape",
                ActionTypeId = OneAction.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("5055a0f7-a922-4b49-b57f-40938f30d803"), Text = "You attempt to escape from being grabbed, immobilized, or restrained. Choose one creature, object, spell effect, hazard, or other impediment imposing any of those conditions on you. Attempt a check using your unarmed attack modifier against the DC of the effect. This is typically the Athletics DC of a creature grabbing you, the Thievery DC of a creature who tied you up, the spell DC for a spell effect, or the listed Escape DC of an object, hazard, or other impediment. You can attempt an Acrobatics or Athletics check instead of using your attack modifier if you choose (but this action still has the attack trait)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Attack.ID;
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("42f02449-6552-40db-adea-e635cb50c071"),
                CriticalSuccess = "You get free and remove the grabbed, immobilized, and restrained conditions imposed by your chosen target. You can then Stride up to 5 feet.",
                Success = "You get free and remove the grabbed, immobilized, and restrained conditions imposed by your chosen target.",
                CriticalFailure = "You don’t get free, and you can’t attempt to Escape again until your next turn."
            };
        }
    }
}
