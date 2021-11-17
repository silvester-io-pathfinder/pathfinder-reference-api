using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.AdventuringGears.Instances
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
                Hands = "1",
                Price = 1000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("ea003b92-0cfb-48a6-926b-af438b7df2e9"), Type = TextBlockType.Text, Text = "Maps are uncommon. Most maps you can find are simple and functional. A survey map details a single location in excellent detail. One of these maps gives you a +1 item bonus to Survival checks and any skill checks to Recall Knowledge, provided the checks are related to the location detailed on the map." };
            yield return new TextBlock { Id = Guid.Parse("1c23e4bd-0eb1-49f8-a154-ef25ccb88a61"), Type = TextBlockType.Text, Text = "The GM determines what maps are available in any location." };
        }

        protected override IEnumerable<AdventuringGearVariant> GetVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("db15d73d-9a45-4ac4-9d6f-e0edf5013e97"),
                NameAddendum = "Atlas",
                DescriptionAddendum = "Maps sometimes come in atlases, containing a number of maps of the same quality, often on similar topics. An atlas costs five times as much as a single map and requires both hands to use.",
                ItemLevel = 3,
                Price = 5000,
                Hands = 2,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a43f7e62-70e2-42db-9531-46c06eba4447"),
                SourceId = CoreRulebook.ID,
                Page = 291
            };
        }
    }
}
