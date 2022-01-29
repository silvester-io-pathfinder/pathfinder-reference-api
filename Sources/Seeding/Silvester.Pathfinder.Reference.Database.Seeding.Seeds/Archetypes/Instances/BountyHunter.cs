using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Archetypes.Instances
{
    public class BountyHunter : Template
    {
        public static readonly Guid ID = Guid.Parse("59575b9d-350e-4e87-9eec-a1be45fc0ac6");
        
        protected override Archetype GetArchetype()
        {
            return new Archetype
            {
                Id = ID, 
                Name = "Bounty Hunter",
                DedicationFeatId = Feats.Instances.BountyHunterDedication.ID 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("8c83766a-4787-4ecb-82b9-3b27d6d52198"), Type = TextBlockType.Text, Text = "Whether for coin, glory, or justice, you know how to track, defeat, and capture dangerous individuals. you're accustomed to perusing wanted posters, searching up on leads, and pursuing villains to hell and back." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ba0b4ee8-c8c3-4f3f-bcbf-20c78a02afda"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 163
            };
        }
    }
}
