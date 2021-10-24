using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Abilities.Instances
{
    public class Regeneration : Template
    {
        public static readonly Guid ID = Guid.Parse("a1c457ed-04b1-4f73-b9ec-76801434d30d");

        protected override Ability GetAbility()
        {
            return new Ability
            {
                Id = ID,
                Name = "Regeneration",
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetEffects()
        {
            yield return new TextBlock { Id = Guid.Parse("40be1576-f423-47e5-afb4-98db2d0506b8"), Text = "This monster regains the listed number of Hit Points each round at the beginning of its turn. Its dying condition never increases beyond dying 3 as long as its regeneration is active. However, if it takes damage of a type listed in the regeneration entry, its regeneration deactivates until the end of its next turn. Deactivate the regeneration before applying any damage of a listed type, since that damage might kill the monster by bringing it to dying 4." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ec16d9d8-94b0-4abb-933e-1e6aec1a446d"),
                SourceId = Sources.Instances.Bestiary.ID,
                Page = 343
            };
        }
    }
}
