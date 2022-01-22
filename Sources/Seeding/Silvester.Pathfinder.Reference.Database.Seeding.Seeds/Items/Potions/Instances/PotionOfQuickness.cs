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
    public class PotionOfQuickness : Template
    {
        public static readonly Guid ID = Guid.Parse("789398f7-09b0-407e-b169-56a89f92b834");

        protected override Potion GetPotion()
        {
            return new Potion
            {
                Id = ID,
                Name = "Potion of Quickness",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("a4485afe-c7d8-4185-b7e0-fee5e94c9751"), "Drinking this silver potion grants you the effects of haste for 1 minute.");
        }

        protected override IEnumerable<PotionVariant> GetPotionVariants()
        {
            yield return new PotionVariant
            {
                Id = Guid.Parse("3793be9a-d29a-4607-857d-8b3ab00153d4"),
                Name = "Potion of Quickness",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 8,
                Price = 9000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("4603b0bb-1d7d-4d13-a5de-b2e9ecf14541"), ActionTypes.Instances.OneAction.ID, "Activate", action => 
                    {
                        action.Kind("Interact");
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("7be45f5c-b3d9-414f-9740-60329289104f"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("db33af0f-75e3-43a9-bcd2-69f88007aa73"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("b23cc8e0-05e3-4c15-8145-6910cb9488dc"), Traits.Instances.Potion.ID);
            builder.Add(Guid.Parse("5a801c6a-65b8-4916-8328-b7ef05ae2ddf"), Traits.Instances.Transmutation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7d1c939f-d2d7-407d-b590-056b0a01429f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 563
            };
        }
    }
}
