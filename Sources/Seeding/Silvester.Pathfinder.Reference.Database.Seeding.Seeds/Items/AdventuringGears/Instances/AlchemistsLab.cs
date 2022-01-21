using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AdventuringGears.Instances
{
    public class AlchemistsLab : Template
    {
        public static readonly Guid ID = Guid.Parse("8f6a633a-5b05-499b-bcf7-459f0a4710f1");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Alchemist's Lab",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("a6c0e44b-e2c7-46d4-92ce-cbaccf522278"), "You need an alchemist's lab to Craft alchemical items during downtime.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("dd43fc95-3633-48a6-8489-d4ffb821f305"),
                Name = "Alchemist's Lab",
                Level = 0,
                Hands = "2",
                Price = 500,
                BulkId = Bulks.Instances.SixBulk.ID,
                RarityId = Rarities.Instances.Common.ID
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("b789ea83-1f28-4146-86e2-fb5193696b72"),
                Name = "Alchemist's Lab (Expanded)",
                Level = 3,
                Hands = "2",
                Price = 5500,
                BulkId = Bulks.Instances.SixBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("17d8c0c0-d940-4d34-bc9a-6d99fa9b2b81"), "An expanded alchemist's lab gives a +1 item bonus to Crafting checks to create alchemical items.")
                    .Build(),
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2686c706-c844-404b-9420-d87e5fa2caac"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 287
            };
        }
    }
}
