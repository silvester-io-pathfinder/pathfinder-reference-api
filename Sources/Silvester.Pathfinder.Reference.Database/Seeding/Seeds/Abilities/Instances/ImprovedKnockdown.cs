using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Abilities.Instances
{
    public class ImprovedKnockdown : Template
    {
        public static readonly Guid ID = Guid.Parse("28655ea3-c634-43ff-b55a-743ee85055c7");

        protected override Ability GetAbility()
        {
            return new Ability
            {
                Id = ID,
                Name = "Improved Knockdown",
                ActionTypeId = ActionTypes.Instances.FreeAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetEffects()
        {
            yield return new TextBlock { Id = Guid.Parse("43da8b37-5784-4385-aaf0-2979e5ebe119"), Text = "The monster can use Knockdown as a free action triggered by a hit with its initial attack." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("18940d47-9647-4e73-9b10-8c23be3da4dc"),
                SourceId = Sources.Instances.Bestiary.ID,
                Page = 343
            };
        }
    }
}
