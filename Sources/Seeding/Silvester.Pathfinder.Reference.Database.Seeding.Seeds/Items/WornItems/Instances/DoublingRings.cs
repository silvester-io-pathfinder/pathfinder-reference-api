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
    public class DoublingRings : Template
    {
        public static readonly Guid ID = Guid.Parse("825930d0-89ba-4014-aba7-fe71394bc01e");
        
        protected override WornItem GetWornItem()
        {
            return new WornItem
            {
                Id = ID, 
                Name = "Doubling Rings",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("9ccf0773-f693-46f1-bb72-5f852d0c329f"), "This item consists of two magically linked rings: an intricate, gleaming golden ring with a square-cut ruby, and a thick, plain iron ring. When you wield a melee weapon in the hand wearing the golden ring, the weapon's fundamental runes are replicated onto any melee weapon you wield in the hand wearing the iron ring. (The fundamental runes are weapon potency and striking, which add an item bonus to attack rolls and extra weapon damage dice, respectively.) Any fundamental runes on the weapon in the hand wearing the iron ring are suppressed.");
            builder.Text(Guid.Parse("78f44877-fa9e-40e3-9b37-1232b3a5003c"), "The replication functions only if you wear both rings, and it ends as soon as you cease wielding a melee weapon in one of your hands. Consequently, the benefit doesn't apply to thrown attacks or if you're holding a weapon but not wielding it (such as holding in one hand a weapon that requires two hands to wield).");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("9971ece7-472b-4cda-b0fe-7004a7046a03"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("61cfc380-02b8-45e3-9f88-af1a980d3dc7"), Traits.Instances.Invested.ID);
            builder.Add(Guid.Parse("f85310ca-26c8-4227-a7f3-85234c10baa4"), Traits.Instances.Magical.ID);
        }

        protected override IEnumerable<WornItemVariant> GetWornItemVariants()
        {
            yield return new WornItemVariant
            {
                Id = Guid.Parse("a1ce30bb-3df7-491c-8adf-7e929467a4a4"),
                Name = "Doubling Rings",
                Usage = "Worn.",
                Level = 3,
                Price = 5000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };

            yield return new WornItemVariant
            {
                Id = Guid.Parse("14030c56-d315-4cd7-9f59-16f46b3bc968"),
                Name = "Doubling Rings (Greater)",
                Usage = "Worn.",
                Level = 11,
                Price = 130000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("adb140c1-3c72-44bd-a974-ed4d57e46602"), "The rings also replicate property runes from the weapon in the gold-ringed hand, so long as the weapon in the iron-ringed hand meets all the prerequisites for a given rune and is not a specific weapon. The weapon in the iron-ringed hand gains the benefits of those runes. All its own runes are suppressed. When you invest the rings, you can elect for the rings to transfer only fundamental runes, in which case they function as standard doubling rings.")
                    .Build(),
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9b0f112c-ce9b-4ca3-b9ac-8a90b9863c9b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 609
            };
        }
    }
}
