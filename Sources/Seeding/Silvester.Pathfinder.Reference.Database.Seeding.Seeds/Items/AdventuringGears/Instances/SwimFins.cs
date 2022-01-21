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
    public class SwimFins : Template
    {
        public static readonly Guid ID = Guid.Parse("0dc8ba27-c35d-430b-ac20-5ae0e659ca86");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Swim Fins",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("4482f6cb-0808-4a4a-b543-a15fe80c1ccf"), "These flippers attach to your feet like tight shoes—donning or removing them requires three Interact actions. While worn, you gain a +5-foot item bonus to the distance you move when rolling Athletics to Swim, not when using a swim Speed, and you take a –10-foot item penalty to your Speed.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("a298e695-16dc-46da-b522-65c2a40ca0e5"),
                Name = "Swin Fins",
                Usage = "Worn shoes.",
                Price = 500,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("451042d0-831d-4f24-b3a9-85bbb522f7bb"),
                SourceId = Sources.Instances.WorldGuide.ID,
                Page = 69
            };
        }
    }
}
