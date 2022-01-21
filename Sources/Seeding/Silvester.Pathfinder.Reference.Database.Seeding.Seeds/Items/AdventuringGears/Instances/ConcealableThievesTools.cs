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
    public class ConcealableThievesTools : Template
    {
        public static readonly Guid ID = Guid.Parse("ee932950-fb59-4926-beee-dab8ef1c74f4");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Concealable Thieves' Tools",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("375853c1-8977-445e-ad4c-b5874d6cddb8"), "You need thieves' tools to Pick Locks or Disable Devices (of some types) using the Thievery skill. If your thieves' tools are broken, you can repair them by replacing the lock picks with replacement picks appropriate to your tools; this doesn't require using the Repair action. If you wear your thieves' tools, you can draw and replace them as part of the action that uses them.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("e7f6a9b3-30a8-4d87-b310-cb827dfe2ea0"),
                Name = "Concealable Thieves' Tools",
                Hands = "2",
                Level = 4,
                Price = 8000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("7386b815-1a5c-420e-a018-796508571385"), "Smaller and made of stronger materials than most sets of thieves' tools, the items in this kit are much easier to conceal. You gain a +1 item bonus to Stealth checks to Conceal these tools. They otherwise function as infiltrator thieves' tools.")
                    .Build()
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("010b5e3a-c275-4af9-b9b5-3d5001b055d2"),
                Name = "Concealable Picks",
                Hands = "2",
                Level = 4,
                Price = 1000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("2b794472-dd88-4a60-940d-9a1d2adafbce"), "If your thieves' tools are broken, you can repair them by replacing the lock picks with replacement picks appropriate to your tools; this doesn't require using the Repair action.")
                    .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2be216d7-886c-496e-ba31-385773a64d96"),
                SourceId = Sources.Instances.PathfinderSocietyGuide.ID,
                Page = 114
            };
        }
    }
}
