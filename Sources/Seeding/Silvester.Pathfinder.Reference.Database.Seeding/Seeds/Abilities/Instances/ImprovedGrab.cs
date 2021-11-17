using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Abilities.Instances
{
    public class ImprovedGrab : Template
    {
        public static readonly Guid ID = Guid.Parse("5aab23b2-cfbd-40a9-9248-0b9fa4ad07bf");

        protected override Ability GetAbility()
        {
            return new Ability
            {
                Id = ID,
                Name = "Improved Grab",
                ActionTypeId = ActionTypes.Instances.FreeAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetEffects()
        {
            yield return new TextBlock { Id = Guid.Parse("01f43d00-b968-4eab-81d0-e066e7f63de9"), Text = "The monster can use Grab as a free action triggered by a hit with its initial attack. A monster with Improved Grab still needs to spend an action to extend the duration for creatures it already has grabbed." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a8f95a5e-0236-4403-8471-a5317c4b597f"),
                SourceId = Sources.Instances.Bestiary.ID,
                Page = 343
            };
        }
    }
}
