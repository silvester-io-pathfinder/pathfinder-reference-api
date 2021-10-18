using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Archetypes.Instances
{
    public class Duelist : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override Archetype GetArchetype()
        {
            return new Archetype
            {
                Id = ID, 
                Name = "Duelist",
                DedicationFeatId = Feats.Instances.DuelistDedication.ID 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Across the world, students in martial academies practice with their blades to master one-on-one combat. The libraries of such schools hold deep troves of information detailing hundreds of combat techniques, battle stances, and honorable rules of engagement. Those who gain admission to such schools might train in formalized duels—and that’s certainly the more genteel route to take. However, others assert that there’s no better place to try out dueling techniques than in the life-and-death struggles common to an adventurer’s life." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 171
            };
        }
    }
}
