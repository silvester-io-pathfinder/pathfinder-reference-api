using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Archetypes.Instances
{
    public class Poisoner : Template
    {
        public static readonly Guid ID = Guid.Parse("d80b5b2b-01be-4de5-a2cc-c5663b01a5c3");
        
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
            yield return new TextBlock { Id = Guid.Parse("88495d00-7092-45f2-83ea-a29f776b056a"), Type = TextBlockType.Text, Text = "People are so delightfully fragile when exposed to the glories of nature. The bite of a certain serpent makes the blood congeal to jelly. A particular stone, suitably powdered, causes hallucinations and delirium. The sap of a tree inflicts such pain that death seems preferable. You are a student of such dark wonders, making you a dangerous foe indeed." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("55ad8c68-326b-4e07-bc3b-589e4fdefb2c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 186
            };
        }
    }
}
