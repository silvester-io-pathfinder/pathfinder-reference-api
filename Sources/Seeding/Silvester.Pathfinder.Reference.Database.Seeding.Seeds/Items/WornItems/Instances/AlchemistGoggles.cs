using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ItemCategories.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.WornItems.Instances
{
    public class AlchemistGoggles : Template
    {
        public static readonly Guid ID = Guid.Parse("c9c45727-b1bd-4ab7-abf8-dd9cac716a7b");
        
        protected override WornItem GetWornItem()
        {
            return new WornItem
            {
                Id = ID, 
                Name = "Alchemist Goggles",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("b059d2f1-706a-434e-b97f-4314cc34af28"), "These brass goggles are engraved with flame patterns and have thick, heavy lenses. While worn, the eyepiece gives you a +1 item bonus to Crafting checks to Craft alchemical items and a +1 item bonus to attack rolls with alchemical bombs. You can also ignore lesser cover when making Strikes with alchemical bombs.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("31ebdef1-2fc0-499f-a544-d499cc1cd35e"), Traits.Instances.Invested.ID);
            builder.Add(Guid.Parse("f4ef2310-7cc3-4218-b53d-5e032a0a4f43"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("71195ae7-17f8-4320-86c9-f14e98ece1a8"), Traits.Instances.Transmutation.ID);
        }

        protected override IEnumerable<WornItemVariant> GetWornItemVariants()
        {
            yield return new WornItemVariant
            {
                Id = Guid.Parse("8d4756b0-602b-4b34-bc7e-62d1d6435f1b"),
                Name = "Alchemist Goggles",
                Usage = "Worn eyepiece.",
                Level = 4,
                Price = 10000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };

            yield return new WornItemVariant
            {
                Id = Guid.Parse("7a29ca06-9714-4869-8e77-f6b3f0a72f8d"),
                Name = "Alchemist Goggles (Greater)",
                Usage = "Worn eyepiece.",
                Level = 11,
                Price = 140000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("c3fe0193-2694-4d2e-b143-029adafc951f"), "While worn, the eyepiece gives you a +2 item bonus to Crafting checks to Craft alchemical items and a +2 item bonus to attack rolls with alchemical bombs. You can also ignore lesser cover when making Strikes with alchemical bombs.")
                    .Build(),
            };

            yield return new WornItemVariant
            {
                Id = Guid.Parse("b4981fab-6f6f-4722-9b74-8855a1f251a8"),
                Name = "Alchemist Goggles (Major)",
                Usage = "Worn eyepiece.",
                Level = 17,
                Price = 1500000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("81131a13-76a5-49f0-84b7-b728d6eb47be"), "While worn, the eyepiece gives you a +3 item bonus to Crafting checks to Craft alchemical items and a +3 item bonus to attack rolls with alchemical bombs. You can also ignore lesser cover when making Strikes with alchemical bombs.")
                    .Build(),
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e010760d-f6b9-4184-ae56-485857651448"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 605
            };
        }
    }
}
