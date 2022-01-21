using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.FamiliarAbilities.Instances
{
    public class Toolbearer : Template
    {
        public static readonly Guid ID = Guid.Parse("3446ffae-557f-490f-8dd2-5014bf1013c7");

        protected override FamiliarAbility GetFamiliarAbility()
        {
            return new FamiliarAbility
            {
                Id = ID, 
                Name = "Toolbearer", 
                Description = "Your familiar can carry a set of tools of up to light Bulk. So long as your familiar is adjacent to you, you can draw and replace the tools as part of the action that uses them as if you were wearing them. Your familiar must have the manual dexterity ability to select this."
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("06a28e34-a15d-4493-9825-7a5e4c159f6c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 146
            };
        }
    }
}
