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
    public class PotionOfTongues : Template
    {
        public static readonly Guid ID = Guid.Parse("bed931a8-ccf2-47f9-82be-0658bba4e247");

        protected override Potion GetPotion()
        {
            return new Potion
            {
                Id = ID,
                Name = "Potion of Tongues",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("78a260b2-5549-467f-8a16-364fc9895961"), "This sour potion enlivens your tongue with unusual flavors and uncommon eloquence, allowing you to speak and understand all languages for 4 hours after you drink it. This doesn�t allow you to read these languages in their written form.");
        }

        protected override IEnumerable<PotionVariant> GetPotionVariants()
        {
            yield return new PotionVariant
            {
                Id = Guid.Parse("0bfcdf8a-9232-44f9-83c6-698aeaca7b67"),
                Name = "Potion of Tongues",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 12,
                Price = 32000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("c2dee370-1b94-4766-9052-eac6f27dabd1"), ActionTypes.Instances.OneAction.ID, "Activate", action => 
                    {
                        action.Kind("Interact");
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("ed93ab0b-8c82-4cb7-a2e5-5f6c84be5153"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("bfec1b4b-f32f-4314-93c2-d99ac4227c23"), Traits.Instances.Divination.ID);
            builder.Add(Guid.Parse("6752c09a-60b5-4570-82b9-08fa82bda871"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("5c01e891-7850-4749-95d1-a5aba186ad93"), Traits.Instances.Potion.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("dce283d7-6577-4293-92a6-bcab82217d17"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 563
            };
        }
    }
}
