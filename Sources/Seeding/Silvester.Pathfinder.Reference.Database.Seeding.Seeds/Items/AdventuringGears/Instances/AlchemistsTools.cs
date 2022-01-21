using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AdventuringGears.Instances
{
    public class AlchemistsTools : Template
    {
        public static readonly Guid ID = Guid.Parse("9fbc54ea-d3f5-4fd8-8b5d-1b1cd539745e");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Alchemist's Tools",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("bfb8773e-71f4-42ee-bd96-b8dd4ed2630a"), "This mobile collection of vials and chemicals can be used for simple alchemical tasks. If you wear your alchemist's tools, you can draw and replace them as part of the action that uses them.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("78ed5665-5b3a-464b-ab38-64015c47b907"),
                Name = "Alchemist's Tools",
                Hands = "2",
                Level = 0,
                Price = 300,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e8e92ed4-2146-44db-a5d0-1c6050e51c93"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 289
            };
        }
    }
}
