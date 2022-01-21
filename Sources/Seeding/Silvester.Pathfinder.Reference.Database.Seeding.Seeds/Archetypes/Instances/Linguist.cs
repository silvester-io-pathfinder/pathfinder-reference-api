using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Archetypes.Instances
{
    public class Linguist : Template
    {
        public static readonly Guid ID = Guid.Parse("b1d5f172-5d6d-4a02-8d82-ea0791bc85c0");
        
        protected override Archetype GetArchetype()
        {
            return new Archetype
            {
                Id = ID, 
                Name = "Linguist",
                DedicationFeatId = Feats.Instances.LinguistDedication.ID 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("6997785e-f7ab-45d1-8309-6cb72bca6f03"), Type = TextBlockType.Text, Text = "Whether you study to further your own ambitions or simply out of fascination with the intricacies of language, your way with words is unparalleled." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9132989d-2e72-4c24-958c-8884a34c54fd"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 178
            };
        }
    }
}
