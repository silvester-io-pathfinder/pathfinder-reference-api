using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Archetypes.Instances
{
    public class Archaeologist : Template
    {
        public static readonly Guid ID = Guid.Parse("72593d9b-99d5-4cf4-a83a-68dfb07f330d");
        
        protected override Archetype GetArchetype()
        {
            return new Archetype
            {
                Id = ID, 
                Name = "Archaeologist",
                DedicationFeatId = Feats.Instances.ArchaeologistDedication.ID 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("a448b051-d974-4c41-893d-d7f488946b66"), Type = TextBlockType.Text, Text = "Adventurers raid tombs for material gain, but true archaeologists treasure the knowledge gained from such sites. You might accomplish your goals with scholarly learning, by training to overcome the tricks and traps set by ancient peoples and rivals, through magical training, or even with a bit of inexplicable luck." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7a048d12-e5ef-4108-82b4-fbc29eec86c1"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 156
            };
        }
    }
}
