using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AdventuringGears.Instances
{
    public class TearAwayClothing : Template
    {
        public static readonly Guid ID = Guid.Parse("25ea396a-0fd9-4a95-b62f-b929db4794f0");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Tear-Away Clothing",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("d911ea33-5ffe-478c-baf0-75b0d2a4e6e3"), "Performers and criminals are both known to use disposable clothing designed to be torn off the body quickly and easily. This garment is loose enough to be worn over another outfit, including light armor. You can remove tear-away clothing with an Interact action. The price for tear-away clothing is to modify an existing outfit. If purchasing a new outfit, add the tear-away clothing's price to the outfit to modify it as part of the purchase.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("37f68f01-73d8-45cc-a163-4cc35b183525"),
                Name = "Tear-Away Clothing",
                Usage = "Modifies existing clothing.",
                Level = 0,
                Price = 50,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("724a2c18-ecea-47a2-a28d-89b7284523aa"),
                SourceId = Sources.Instances.GrandBazaar.ID,
                Page = 93
            };
        }
    }
}
