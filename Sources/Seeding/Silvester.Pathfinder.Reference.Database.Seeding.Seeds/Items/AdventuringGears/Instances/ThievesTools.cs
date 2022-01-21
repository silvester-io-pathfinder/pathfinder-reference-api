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
    public class ThievesTools : Template
    {
        public static readonly Guid ID = Guid.Parse("ed04caf1-99ba-4aec-ac16-ca08057f7d22");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Thieves' Tools",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("0415e3bc-5c72-4d38-aaca-4e00ae630b54"), "You need thieves' tools to Pick Locks or Disable Devices (of some types) using the Thievery skill. If your thieves' tools are broken, you can repair them by replacing the lock picks with replacement picks appropriate to your tools; this doesn't require using the Repair action. If you wear your thieves' tools, you can draw and replace them as part of the action that uses them.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("882afae7-e428-4e9c-89ac-2bbc8c4de3f6"),
                Name = "Thieves' Tools",
                Hands = "2",
                Level = 0,
                Price = 300,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("534b3a2f-fc09-471c-93d5-a064eff0dcb2"),
                Name = "Thieves' Tools (Replacement Picks)",
                Hands = "2",
                Level = 0,
                Price = 30,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                   .Text(Guid.Parse("2378ad31-0d90-4e9d-a6bb-ba9c4d6b3ef7"), "If your thieves' tools are broken, you can repair them by replacing the lock picks with replacement picks appropriate to your tools; this doesn't require using the Repair action.")
                   .Build()
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("64ba1b4f-b660-420d-a8b8-43de553396cf"),
                Name = "Thieves' Tools (Infiltrator)",
                Hands = "2",
                Level = 3,
                Price = 300,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                   .Text(Guid.Parse("48f09527-1206-4002-9bcf-938c3a94fd10"), "If your thieves' tools are broken, you can repair them by replacing the lock picks with replacement picks appropriate to your tools; this doesn't require using the Repair action.")
                   .Build()
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("4efe5c56-7224-49d0-8418-e85a9d5bd414"),
                Name = "Thieves' Tools (Infiltrator Picks)",
                Hands = "2",
                Level = 0,
                Price = 5000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                   .Text(Guid.Parse("4bc12bfb-91f3-476f-86e1-0a70360d9c59"), "Infiltrator thieves' tools add a +1 item bonus to checks to Pick Locks and Disable Devices.")
                   .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1acf0154-8631-4223-9194-45fe850cb93f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 291
            };
        }
    }
}
