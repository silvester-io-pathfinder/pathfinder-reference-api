using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AdventuringGears.Instances
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
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("946cabe1-a23c-442f-8bba-767d17af7ec8"), "Made of waxed cotton or cork, earplugs give you a +1 item bonus to saves against effects with the auditory trait. The earplugs make it difficult to hear, however, imposing a –2 item penalty on Perception checks involving sound. Inserting or removing the earplugs requires an Interact action.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("69786bf7-bd04-46f2-bdaa-6f79caa35bdd"),
                Name = "Earplugs",
                Level = 0,
                Hands = "1",
                Price = 1,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2cad9712-fbd7-42aa-85b0-e1d498651b94"),
                SourceId = Sources.Instances.PathfinderSocietyGuide.ID,
                Page = 114
            };
        }
    }
}
