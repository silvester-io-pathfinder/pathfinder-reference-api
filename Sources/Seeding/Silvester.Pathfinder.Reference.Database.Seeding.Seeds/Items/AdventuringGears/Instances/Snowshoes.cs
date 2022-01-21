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
    public class Snowshoes : Template
    {
        public static readonly Guid ID = Guid.Parse("361e8665-4225-4915-a3fa-f75b9a619b6b");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Snowshoes",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("71593858-9d82-46ff-8893-c1d0f62a6c19"), "These specialized pieces of footwear are designed to distribute the wearer's weight over a larger area to prevent them from sinking while walking on snow. They are typically made with a wood frame and rawhide lacings that are tied over the wearer's other footwear. While wearing snowshoes, you ignore the effects of non-magical difficult terrain caused by snow (reducing greater difficult terrain from snow to ordinary difficult terrain). You take a –10-foot item penalty to your Speed if wearing snowshoes while walking on any surface other than snow.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("0fec1d8a-2a89-41a6-8d20-b3ea96277d7a"),
                Name = "Snowshoes",
                Level = 0,
                Price = 1000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("88efa217-6a95-4582-942b-f1af8d98aea8"),
                SourceId = Sources.Instances.PathfinderSocietyGuide.ID,
                Page = 115
            };
        }
    }
}
