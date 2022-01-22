using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System;
using System.Collections.Generic;


namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Potions.Instances
{
    public class SerumOfSexShift : Template
    {
        public static readonly Guid ID = Guid.Parse("41dccbde-7f64-4b6d-b892-67619a86b320");

        protected override Potion GetPotion()
        {
            return new Potion
            {
                Id = ID,
                Name = "Serum of Sex Shift",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("3e23cf6c-123a-4134-9b34-c81c528fe6f6"), "Upon drinking this potion, your biology instantly transforms to take on a set of sexual characteristics of your choice, changing your appearance and physiology accordingly. You have mild control over the details of this change, but you retain a strong �family resemblance� to your former appearance.");
            builder.Text(Guid.Parse("258e9dcb-62db-4078-bda9-e8bc80bcba05"), "The magic functions instantaneously and can�t be counteracted. Your new anatomy is as healthy and functional as your previous body�s, potentially allowing you to procreate (depending on your ancestry�s biology). Drinking a subsequent serum of sex shift allows you to either revert back to your original form or adopt other sexual characteristics, as you choose. The elixir has no effect if you are pregnant or from an ancestry with no sexual differentiation. Most ancestries have a wide spectrum of sexual differentiation, some common, others more rare.");
        }

        protected override IEnumerable<PotionVariant> GetPotionVariants()
        {
            yield return new PotionVariant
            {
                Id = Guid.Parse("e71ff940-b2ef-4b75-b400-05b1a5535c95"),
                Name = "Serum of Sex Shift",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 7,
                Price = 6000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("ea387fba-2b1d-4b6c-bfb5-3a01003403e0"), ActionTypes.Instances.OneAction.ID, "Activate", action => 
                    {
                        action.Kind("Interact");
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("5ca5730c-5eee-4249-9b7d-5404e98a5324"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("a60010a8-fa9e-4aea-892d-a22f0b2934b0"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("5d5b986c-f496-4d76-98a9-c38b29fb9b28"), Traits.Instances.Potion.ID);
            builder.Add(Guid.Parse("f63a6e27-1d31-426b-85aa-9ab991ad9902"), Traits.Instances.Transmutation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("25b4865b-e3c9-4cb0-aae3-456d6f11092b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 564
            };
        }
    }
}
