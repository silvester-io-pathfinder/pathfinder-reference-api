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
    public class Manacles : Template
    {
        public static readonly Guid ID = Guid.Parse("2ee4c581-edef-47ed-8654-086ee333d890");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Manacles",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("c3dfc079-a58c-4c0d-a8f5-75cbc07121ab"), "You can manacle someone who is willing or otherwise at your mercy as an exploration activity taking 10-30 seconds depending on the creature's size and how many manacles you apply. A two-legged creature with its legs bound takes a -15-foot circumstance penalty to its Speeds, and a two-handed creature with its wrists bound has to succeed at a DC 5 flat check any time it uses a manipulate action or else that action fails. This DC may be higher depending on how tightly the manacles constrain the hands. A creature bound to a stationary object is immobilized. For creatures with more or fewer limbs, the GM determines what effect manacles have, if any.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("ab61c34e-6bab-4c85-ad11-7cfaeaa20ac4"),
                Name = "Manacles (Poor)",
                Hands = "2",
                Level = 0,
                Price = 30,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("adce1793-4281-4eca-87f1-212f8eeb9e80"), "Freeing a creature from poor manacles requires two successful DC 17 Thievery checks.")
                    .Build()
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("696b25d5-5498-4850-a214-dbb752e11696"),
                Name = "Manacles (Simple)",
                Hands = "2",
                Level = 1,
                Price = 300,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("4d29e8fe-8fc2-4c38-89d6-3ec66cdee8ac"), "Freeing a creature from simple manacles three successful DC 22 Thievery checks.")
                    .Build()
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("0e173d1a-f0d6-48ef-99ad-2fa55099305e"),
                Name = "Manacles (Average)",
                Hands = "2",
                Level = 3,
                Price = 2000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("7a9bf189-35cd-49de-bfc2-8c518bc47d3b"), "Freeing a creature from average manacles four successful DC 27 Thievery checks.")
                    .Build()
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("38297239-ba88-499a-b1bd-d6d333eacf2c"),
                Name = "Manacles (Good)",
                Hands = "2",
                Level = 9,
                Price = 25000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("e3b7319e-b664-4e40-8193-e97a125c2e9c"), "Freeing a creature from good manacles five successful DC 32 Thievery checks.")
                    .Build()
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("2c92133b-cce0-431a-89dd-9cfb260387ce"),
                Name = "Manacles (Superior)",
                Hands = "2",
                Level = 17,
                Price = 500000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("c35b5ceb-1b0a-4bb5-bfd8-bdffe9621321"), "Freeing a creature from good manacles six successful DC 42 Thievery checks.")
                    .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3af578c8-cf70-4cce-b145-ecbafd875738"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 290
            };
        }
    }
}
