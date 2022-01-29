using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Archetypes.Instances
{
    public class HorizonWalker : Template
    {
        public static readonly Guid ID = Guid.Parse("b9ebf3dc-0f04-454b-aabc-ae8395cbd8f1");
        
        protected override Archetype GetArchetype()
        {
            return new Archetype
            {
                Id = ID, 
                Name = "Horizon Walker",
                DedicationFeatId = Feats.Instances.HorizonWalkerDedication.ID 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("1b63e810-221f-4ff1-9f14-a4de0e83b55b"), Type = TextBlockType.Text, Text = "Many long for the open road, but you prefer the trackless wild. You can find safe passage through the most inhospitable terrain in the world - icecaps, deserts, and similar environs are where you're comfortable. Your talents open untrod paths for you and help guide others through the wilderness." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d7830d08-b12e-473d-aaf6-f2fe73497539"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 177
            };
        }
    }
}
