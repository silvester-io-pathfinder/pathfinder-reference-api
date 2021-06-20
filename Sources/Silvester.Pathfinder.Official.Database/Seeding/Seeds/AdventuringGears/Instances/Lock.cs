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
    public class Lock : Template
    {
        public static readonly Guid ID = Guid.Parse("93f381c5-9d0f-4b47-a652-7ae50f5d5fb5");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Lock",
                Hands = "2",
                Price = 20,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override IEnumerable<AdventuringGearVariant> GetVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("657fb33a-533a-4138-a4e1-b348704713d8"),
                NameAddendum = "Poor",
                DescriptionAddendum = "Picking a poor lock requires two successful DC 15 Thievery checks.",
                ItemLevel = 0,
                Price = 20,
                Hands = 2,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("40e0eb38-8162-4562-b875-743e53276321"),
                NameAddendum = "Simple",
                DescriptionAddendum = "Picking a simple lock requires three successful DC 20 Thievery checks.",
                ItemLevel = 1,
                Price = 200,
                Hands = 2,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("86ff25f4-1577-428f-b220-c271c58b8437"),
                NameAddendum = "Average",
                DescriptionAddendum = "Picking an average lock requires four successful DC 25 Thievery checks.",
                ItemLevel = 3,
                Price = 1500,
                Hands = 2,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("007d34fc-a615-4980-9e52-a48ad6380eeb"),
                NameAddendum = "Good",
                DescriptionAddendum = "Picking a good lock requires five successful DC 30 Thievery checks.",
                ItemLevel = 9,
                Price = 20000,
                Hands = 2,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("8cc2785d-d1e9-4c35-8b60-3b9b7cc4dfcc"),
                NameAddendum = "Superior",
                DescriptionAddendum = "Picking a superior lock requires six successful DC 40 Thievery checks.",
                ItemLevel = 17,
                Price = 450000,
                Hands = 2,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("9b4cdbfb-ef66-4252-8abc-3333ba9be0da"), Type = TextBlockType.Text, Text = "A lock can be used to secure chests, rooms, trapdoors, hatches or other kinds of stowing fascilities." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a66ba719-19fd-470b-977a-06d1fceedb5f"),
                SourceId = CoreRulebook.ID,
                Page = 290
            };
        }
    }
}
