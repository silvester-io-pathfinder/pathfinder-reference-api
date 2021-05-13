using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AdventuringGears.Instances
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
                Hands = "2",
                ItemLevel = "4",
                Price = 8000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("375853c1-8977-445e-ad4c-b5874d6cddb8"), Type = TextBlockType.Text, Text = "Smaller and made of stronger materials than most sets of thieves' tools, the items in this kit are much easier to conceal. You gain a +1 item bonus to Stealth checks to Conceal these tools. They otherwise function as infiltrator thieves' tools." };
        }

        protected override IEnumerable<AdventuringGearVariant> GetVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("010b5e3a-c275-4af9-b9b5-3d5001b055d2"),
                NameAddendum = "Replacement Picks",
                DescriptionAddendum = "If your thieves' tools are broken, you can repair them by replacing the lock picks with replacement picks appropriate to your tools; this doesn't require using the Repair action.",
                ItemLevel = 4,
                Price = 1000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2be216d7-886c-496e-ba31-385773a64d96"),
                SourceId = PathfinderSocietyGuide.ID,
                Page = 114
            };
        }
    }
}
