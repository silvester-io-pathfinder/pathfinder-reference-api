using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Abilities.Instances
{
    public class AllAroundVision : Template
    {
        public static readonly Guid ID = Guid.Parse("3416e16b-f89d-4b3c-8908-bf93392d24b8");

        protected override Ability GetAbility()
        {
            return new Ability
            {
                Id = ID,
                Name = "All-Around Vision",
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetEffects()
        {
            yield return new TextBlock { Id = Guid.Parse("da05bfbc-d279-4389-8199-3677815e35a1"), Text = "This monster can see in all directions simultaneously, and therefore can't be flanked." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f9fd9c90-5b46-4e5c-997c-0e7124e07310"),
                SourceId = Sources.Instances.Bestiary.ID,
                Page = 342
            };
        }
    }
}
