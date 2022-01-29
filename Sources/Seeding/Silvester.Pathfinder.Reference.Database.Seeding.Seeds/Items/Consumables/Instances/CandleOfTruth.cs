using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System;
using System.Collections.Generic;


namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Talismans.Instances
{
    public class CandleOfTruth : Template
    {
        public static readonly Guid ID = Guid.Parse("55e9019c-f1fb-4356-89d9-1ef77c621fa9");

        protected override Talisman GetTalisman()
        {
            return new Talisman
            {
                Id = ID,
                Name = "Candle of Truth",
            };
        }
        
        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("842ba189-8253-4394-ba2a-23ca53db882b"), "This tapered candle has a golden wick that burns with white fire. You activate the candle by lighting it, which causes creatures within 10 feet of the candle to find it difficult to tell falsehoods. Creatures in the area receive a -4 status penalty to Lie.");
            builder.Text(Guid.Parse("7f018443-566c-46ce-93da-6a48bf847193"), "In addition, when first entering the affected area, each creature (including you) must succeed at a DC 26 Will save or be unable to tell any deliberate lies while within 10 feet of the lit candle. This lasts for as long as the candle is lit. Once lit, the candle burns for 10 minutes, and it cannot be extinguished.");
        }

        protected override IEnumerable<TalismanVariant> GetTalismanVariants()
        {
            yield return new TalismanVariant
            {
                Id = Guid.Parse("91bc44cf-094a-49c3-a8c6-12b9410958ca"),
                Name = "Candle of Truth",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 8,
                Price = 7500,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("65f24740-3acf-4eec-b428-f6925013006b"), ActionTypes.Instances.OneAction.ID, "Activate", action => 
                    {
                        action.Kind("Interact");
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("f73be151-ae98-4e4d-8ffd-14e328d84585"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("cf8bb9d4-df18-4679-b66c-daba8a3ac827"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("ffec7ff9-b79b-4d27-a39d-5c65ccf96b12"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("a2104d8a-1780-443d-a11a-dc176eeddb92"), Traits.Instances.Mental.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8b8a733a-9e85-43f4-ac89-97d31f4c6be5"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 570
            };
        }
    }
}
