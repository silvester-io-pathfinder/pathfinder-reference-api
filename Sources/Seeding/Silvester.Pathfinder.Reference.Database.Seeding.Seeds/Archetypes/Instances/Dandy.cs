using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Archetypes.Instances
{
    public class Dandy : Template
    {
        public static readonly Guid ID = Guid.Parse("ce880183-fca9-4e83-9b57-3df641a25c30");
        
        protected override Archetype GetArchetype()
        {
            return new Archetype
            {
                Id = ID, 
                Name = "Dandy",
                DedicationFeatId = Feats.Instances.DandyDedication.ID 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("4e794cb6-864b-4f04-a678-4e8d9328a196"), Type = TextBlockType.Text, Text = "You are a genteel master of style, culture, and decorum, aware of even the subtlest rules of etiquette. Whether you were born into status, acquired it later in life, or merely pretend to possess it, you look and act your part to manicured perfection." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("731f1c7c-137b-4b34-aa54-e6ca490a6fc0"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 167
            };
        }
    }
}
