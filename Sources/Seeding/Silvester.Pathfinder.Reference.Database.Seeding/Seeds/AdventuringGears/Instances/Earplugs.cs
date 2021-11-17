using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.AdventuringGears.Instances
{
    public class Earplugs : Template
    {
        public static readonly Guid ID = Guid.Parse("7214321a-e14d-4c1b-bcf5-642d0b1bb41c");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear
            {
                Id = ID,
                Name = "Earplugs",
                Hands = "0",
                Price = 1,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("946cabe1-a23c-442f-8bba-767d17af7ec8"), Type = TextBlockType.Text, Text = "Made of waxed cotton or cork, earplugs give you a +1 item bonus to saves against effects with the auditory trait. The earplugs make it difficult to hear, however, imposing a –2 item penalty on Perception checks involving sound. Inserting or removing the earplugs requires an Interact action." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2cad9712-fbd7-42aa-85b0-e1d498651b94"),
                SourceId = PathfinderSocietyGuide.ID,
                Page = 114
            };
        }
    }
}
