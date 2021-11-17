using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.FamiliarAbilities.Instances
{
    public class LabAssistant : Template
    {
        public static readonly Guid ID = Guid.Parse("b808bb42-dc2c-4471-847a-fc6b8093dbd4");

        protected override FamiliarAbility GetFamiliarAbility()
        {
            return new FamiliarAbility
            {
                Id = ID, 
                Name = "Lab Assistant", 
                Description = "It can use your Quick Alchemy action. You must have Quick Alchemy, and your familiar must be in your space. This has the same cost and requirement as if you used it. It must have the manual dexterity ability to select this."
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0be12e91-ad98-45d6-a56a-9465c6420047"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 218
            };
        }
    }
}
