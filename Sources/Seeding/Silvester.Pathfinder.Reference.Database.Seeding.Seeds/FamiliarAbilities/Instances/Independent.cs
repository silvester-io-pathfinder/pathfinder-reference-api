using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.FamiliarAbilities.Instances
{
    public class Independent : Template
    {
        public static readonly Guid ID = Guid.Parse("2ee73dcf-9beb-497b-9ebc-ca799ee54c71");

        protected override FamiliarAbility GetFamiliarAbility()
        {
            return new FamiliarAbility
            {
                Id = ID, 
                Name = "Independent", 
                Description = "In an encounter, if you don't Command your familiar, it still gains 1 action each round. Typically, you still decide how it spends that action, but, the GM might determine that your familiar chooses its own tactics rather than performing your preferred action."
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("66d1234d-dd6b-4391-bef5-088af2555e71"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 146
            };
        }
    }
}
