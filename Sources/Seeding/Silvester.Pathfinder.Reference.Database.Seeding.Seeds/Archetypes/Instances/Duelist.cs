using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Archetypes.Instances
{
    public class Duelist : Template
    {
        public static readonly Guid ID = Guid.Parse("9cd4ec68-cac0-4114-90ee-83e254061f7b");
        
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
            yield return new TextBlock { Id = Guid.Parse("c76a845c-5d5b-4f36-bd96-25b1252316b3"), Type = TextBlockType.Text, Text = "Across the world, students in martial academies practice with their blades to master one-on-one combat. The libraries of such schools hold deep troves of information detailing hundreds of combat techniques, battle stances, and honorable rules of engagement. Those who gain admission to such schools might train in formalized duels - and that's certainly the more genteel route to take. However, others assert that there's no better place to try out dueling techniques than in the life-and-death struggles common to an adventurer's life." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3c335352-6507-4555-a86c-488d17c597b5"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 171
            };
        }
    }
}
