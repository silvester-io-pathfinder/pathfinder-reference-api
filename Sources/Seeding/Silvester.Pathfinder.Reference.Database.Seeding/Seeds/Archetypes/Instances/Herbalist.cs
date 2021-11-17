using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Archetypes.Instances
{
    public class Herbalist : Template
    {
        public static readonly Guid ID = Guid.Parse("87abfeac-02d8-45c3-93a4-90bcd399e9e6");
        
        protected override Archetype GetArchetype()
        {
            return new Archetype
            {
                Id = ID, 
                Name = "Herbalist",
                DedicationFeatId = Feats.Instances.HerbalistDedication.ID 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("c7c71e34-e654-474f-bb4a-6eecd6978af9"), Type = TextBlockType.Text, Text = "The plants around you can provide more remedies than the finest hospital or temple, and you are skilled in their use." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fdb94164-38e9-46ab-8ead-53dcc6f75a8e"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 176
            };
        }
    }
}
