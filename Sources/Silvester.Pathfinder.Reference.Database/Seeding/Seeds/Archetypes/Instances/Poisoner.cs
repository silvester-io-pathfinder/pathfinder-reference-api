using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Archetypes.Instances
{
    public class Poisoner : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override Archetype GetArchetype()
        {
            return new Archetype
            {
                Id = ID, 
                Name = "Poisoner",
                DedicationFeatId = Feats.Instances.PoisonerDedication.ID 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "People are so delightfully fragile when exposed to the glories of nature. The bite of a certain serpent makes the blood congeal to jelly. A particular stone, suitably powdered, causes hallucinations and delirium. The sap of a tree inflicts such pain that death seems preferable. You are a student of such dark wonders, making you a dangerous foe indeed." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 186
            };
        }
    }
}
