using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Abilities.Instances
{
    public class Grab : Template
    {
        public static readonly Guid ID = Guid.Parse("8dbc08a4-83c5-490b-8a98-b8f26a7bb41e");

        protected override Ability GetAbility()
        {
            return new Ability
            {
                Id = ID,
                Name = "Grab",
                Requirements = "The monster's last action was a success with a Strike that lists Grab in its damage entry, or it has a creature grabbed using this action.",
                ActionTypeId = ActionTypes.Instances.OneAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetEffects()
        {
            yield return new TextBlock { Id = Guid.Parse("53bae751-f5c7-4d90-bf9a-8b7de52ea8e0"), Text = "The monster automatically Grabs the target until the end of the monster's next turn. The creature is grabbed by whichever body part the monster attacked with, and that body part can't be used to Strike creatures until the grab is ended." };
            yield return new TextBlock { Id = Guid.Parse("38438992-38ae-4fda-bc24-9e2f95ea64de"), Text = "Using Grab extends the duration of the monster's Grab until the end of its next turn for all creatures grabbed by it. A grabbed creature can use the Escape action to get out of the grab, and the Grab ends for a grabbed creatures if the monster moves away from it." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d73bfdbf-6449-4b31-8302-3ff42dbbeac2"),
                SourceId = Sources.Instances.Bestiary.ID,
                Page = 343
            };
        }
    }
}
