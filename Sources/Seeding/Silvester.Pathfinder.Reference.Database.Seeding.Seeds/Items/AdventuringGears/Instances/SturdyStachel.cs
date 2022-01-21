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
    public class SturdyStachel : Template
    {
        public static readonly Guid ID = Guid.Parse("a22483eb-0db6-4677-9097-babb09ab0460");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Sturdy Stachel",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("9575701a-4c38-4ee0-bd43-9f6291ca9b2f"), "This heavy backpack of alchemically treated cloth layered over a metal mesh protects its contents from water damage and other harmful effects. It holds up to 4 Bulk of items, and the first 2 Bulk contained within the sturdy satchel do not count against your Bulk limits. The bag has Hardness 5 and 20 Hit Points. As long as the bag remains closed and is not broken, water and other liquids can't seep into it.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("ce4f9720-dc9c-42e4-80e8-264076a18eb7"),
                Name = "Sturdy Satchel",
                Usage = "Worn.",
                Price = 3000,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("807943a9-5e22-48b3-b3d9-54a747232a65"),
                SourceId = Sources.Instances.PathfinderSocietyGuide.ID,
                Page = 34
            };
        }
    }
}
