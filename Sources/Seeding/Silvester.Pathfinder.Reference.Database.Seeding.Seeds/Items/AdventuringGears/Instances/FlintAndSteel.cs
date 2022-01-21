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
    public class FlintAndSteel : Template
    {
        public static readonly Guid ID = Guid.Parse("e4eb94ea-b8f5-4a36-936f-081fd7c559d4");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Flint and Steel",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("b03dccdb-ca14-4dea-b932-a6c3ec425c7d"), "Flint and steel are useful in creating a fire if you have the time to catch a spark, though using them is typically too time-consuming to be practical during an encounter. Even in ideal conditions, using flint and steel to light a flame requires using at least 3 actions, and often significantly longer.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("c423317b-ff53-4de3-98c8-050fb62a40da"),
                Name = "Flint and Steel",
                Hands = "2",
                Level = 0,
                Price = 5,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("95650345-46bd-4622-ae7c-f46d33da8dfb"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 290
            };
        }
    }
}
