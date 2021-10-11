using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Abilities.Instances
{
    public class Ferocity : Template
    {
        public static readonly Guid ID = Guid.Parse("3d91c3e7-9369-4d25-9623-d4573ec6da5f");

        protected override Ability GetAbility()
        {
            return new Ability
            {
                Id = ID,
                Name = "Ferocity",
                Trigger = "The monster is reduced to 0 HP.",
                ActionTypeId = ActionTypes.Instances.Reaction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetEffects()
        {
            yield return new TextBlock { Id = Guid.Parse("20a16eb4-6d3b-4543-ac82-e1117b564b84"), Text = "The monster avoids being knocked out and remains at 1 HP, but its wounded value increases by 1. When it is wounded 3, it can no longer use this ability." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5e4a52f6-f459-45d9-8bcc-9872ef15af8d"),
                SourceId = Sources.Instances.Bestiary.ID,
                Page = 343
            };
        }
    }
}
