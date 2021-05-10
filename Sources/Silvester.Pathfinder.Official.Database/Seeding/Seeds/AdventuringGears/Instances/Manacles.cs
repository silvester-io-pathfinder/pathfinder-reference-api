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
    public class Manacles : AbstractAdventuringGearTemplate
    {
        public static readonly Guid ID = Guid.Parse("2ee4c581-edef-47ed-8654-086ee333d890");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Manacles",
                Hands = "2",
                ItemLevel = "0",
                Price = 30,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("c3dfc079-a58c-4c0d-a8f5-75cbc07121ab"), Type = TextBlockType.Text, Text = "You can manacle someone who is willing or otherwise at your mercy as an exploration activity taking 10-30 seconds depending on the creature's size and how many manacles you apply. A two-legged creature with its legs bound takes a -15-foot circumstance penalty to its Speeds, and a two-handed creature with its wrists bound has to succeed at a DC 5 flat check any time it uses a manipulate action or else that action fails. This DC may be higher depending on how tightly the manacles constrain the hands. A creature bound to a stationary object is immobilized. For creatures with more or fewer limbs, the GM determines what effect manacles have, if any." };
        }

        protected override IEnumerable<AdventuringGearVariant> GetVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("ab61c34e-6bab-4c85-ad11-7cfaeaa20ac4"),
                NameAddendum = "Poor",
                DescriptionAddendum = "Freeing a creature from poor manacles requires two successful DC 17 Thievery checks.",
                ItemLevel = 0,
                Price = 30,
                Hands = 2,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("696b25d5-5498-4850-a214-dbb752e11696"),
                NameAddendum = "Simple",
                DescriptionAddendum = "Freeing a creature from simple manacles three successful DC 22 Thievery checks.",
                ItemLevel = 1,
                Price = 300,
                Hands = 2,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("0e173d1a-f0d6-48ef-99ad-2fa55099305e"),
                NameAddendum = "Average",
                DescriptionAddendum = "Freeing a creature from average manacles four successful DC 27 Thievery checks.",
                ItemLevel = 3,
                Price = 2000,
                Hands = 2,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("38297239-ba88-499a-b1bd-d6d333eacf2c"),
                NameAddendum = "Good",
                DescriptionAddendum = "Freeing a creature from good manacles five successful DC 32 Thievery checks.",
                ItemLevel = 9,
                Price = 25000,
                Hands = 2,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("2c92133b-cce0-431a-89dd-9cfb260387ce"),
                NameAddendum = "Superior",
                DescriptionAddendum = "Freeing a creature from good manacles six successful DC 42 Thievery checks.",
                ItemLevel = 17,
                Price = 500000,
                Hands = 2,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3af578c8-cf70-4cce-b145-ecbafd875738"),
                SourceId = CoreRulebook.ID,
                Page = 290
            };
        }
    }
}
