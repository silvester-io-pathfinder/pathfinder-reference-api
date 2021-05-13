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
    public class ThievesTools : Template
    {
        public static readonly Guid ID = Guid.Parse("ed04caf1-99ba-4aec-ac16-ca08057f7d22");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Thieves' Tools",
                Hands = "2",
                ItemLevel = "0",
                Price = 300,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("0415e3bc-5c72-4d38-aaca-4e00ae630b54"), Type = TextBlockType.Text, Text = "You need thieves' tools to Pick Locks or Disable Devices (of some types) using the Thievery skill. If your thieves' tools are broken, you can repair them by replacing the lock picks with replacement picks appropriate to your tools; this doesn't require using the Repair action. If you wear your thieves' tools, you can draw and replace them as part of the action that uses them." };
        }

        protected override IEnumerable<AdventuringGearVariant> GetVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("534b3a2f-fc09-471c-93d5-a064eff0dcb2"),
                NameAddendum = "Replacement Picks",
                DescriptionAddendum = "If your thieves' tools are broken, you can repair them by replacing the lock picks with replacement picks appropriate to your tools; this doesn't require using the Repair action.",
                ItemLevel = 0,
                Price = 30,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("4efe5c56-7224-49d0-8418-e85a9d5bd414"),
                NameAddendum = "Infiltrator",
                DescriptionAddendum = "Infiltrator thieves' tools add a +1 item bonus to checks to Pick Locks and Disable Devices.",
                ItemLevel = 0,
                Price = 5000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("64ba1b4f-b660-420d-a8b8-43de553396cf"),
                NameAddendum = "Infiltrator",
                DescriptionAddendum = "If your thieves' tools are broken, you can repair them by replacing the lock picks with replacement picks appropriate to your tools; this doesn't require using the Repair action.",
                ItemLevel = 3,
                Price = 300,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1acf0154-8631-4223-9194-45fe850cb93f"),
                SourceId = CoreRulebook.ID,
                Page = 291
            };
        }
    }
}
