using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.FamiliarAbilities.Instances
{
    public class PlantForm : Template
    {
        public static readonly Guid ID = Guid.Parse("fdd95397-8a3e-4cf7-a9d6-f051055c9176");

        protected override FamiliarAbility GetFamiliarAbility()
        {
            return new FamiliarAbility
            {
                Id = ID, 
                Name = "Plant Form", 
                Description = "Your plant familiar can change shape as a single action, transforming into a Tiny plant of a type roughly similar to the familiar's nature. This otherwise uses the effects of tree shape. You must have a familiar with the plant trait, such as a leshy, to select this ability."
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0fa932a4-974e-4a57-be91-dbef6eb0af98"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 146
            };
        }
    }
}
