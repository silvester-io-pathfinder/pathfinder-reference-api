using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Abilities.Instances
{
    public class ImprovedPush : Template
    {
        public static readonly Guid ID = Guid.Parse("f7c4ccbc-a82a-4588-bc74-80a5e96f973a");

        protected override Ability GetAbility()
        {
            return new Ability
            {
                Id = ID,
                Name = "Improved Push",
                ActionTypeId = ActionTypes.Instances.FreeAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetEffects()
        {
            yield return new TextBlock { Id = Guid.Parse("9087c05f-45c6-446e-855c-044c14ccc81d"), Text = "The monster can use Push as a free action triggered by a hit with its initial attack." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f7f023d2-0acd-4aa4-ad6b-57031784b721"),
                SourceId = Sources.Instances.Bestiary.ID,
                Page = 343
            };
        }
    }
}
