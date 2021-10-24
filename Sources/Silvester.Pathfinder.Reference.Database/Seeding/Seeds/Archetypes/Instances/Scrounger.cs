using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Archetypes.Instances
{
    public class Scrounger : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override Archetype GetArchetype()
        {
            return new Archetype
            {
                Id = ID, 
                Name = "Scrounger",
                DedicationFeatId = Feats.Instances.ScroungerDedication.ID 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You have spent countless hours disassembling and rebuilding complex items to learn how they work, giving you the skill to create just about anything from the most unlikely materials. While your improvised items don’t last long, they tend to be just what you need in a pinch, and your enemies find that while they might be able to disarm you, the real challenge is keeping you that way. Locked rooms, diabolical traps, and desperate situations are each their own sort of puzzle to you, and the mundane objects around you are the pieces you use to improvise your own solution." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 190
            };
        }
    }
}
