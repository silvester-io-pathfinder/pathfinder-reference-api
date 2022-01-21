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
    public class SurveyMap : Template
    {
        public static readonly Guid ID = Guid.Parse("3b87d2b2-c05c-42b1-a7d5-9682e65aff87");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Survey Map",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("ea003b92-0cfb-48a6-926b-af438b7df2e9"), "Maps are uncommon. Most maps you can find are simple and functional. A survey map details a single location in excellent detail. One of these maps gives you a +1 item bonus to Survival checks and any skill checks to Recall Knowledge, provided the checks are related to the location detailed on the map.");;
            builder.Text(Guid.Parse("1c23e4bd-0eb1-49f8-a154-ef25ccb88a61"), "The GM determines what maps are available in any location.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("aeb82cc1-e4c6-445f-9304-72cc0cc116ae"),
                Name = "Survey Map",
                Hands = "1",
                Price = 1000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("db15d73d-9a45-4ac4-9d6f-e0edf5013e97"),
                Name = "Survey Map (Atlas)",
                Hands = "2",
                Level = 3,
                Price = 5000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("21789040-1b07-4833-8f13-b6081f9f2826"), "Maps sometimes come in atlases, containing a number of maps of the same quality, often on similar topics. An atlas costs five times as much as a single map and requires both hands to use.")
                    .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a43f7e62-70e2-42db-9531-46c06eba4447"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 291
            };
        }
    }
}
