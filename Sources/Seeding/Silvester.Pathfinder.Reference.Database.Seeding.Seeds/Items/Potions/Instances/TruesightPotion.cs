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
    public class TruesightPotion : Template
    {
        public static readonly Guid ID = Guid.Parse("cbac8efe-11c7-4872-a859-5e8f0b238cc5");

        protected override Potion GetPotion()
        {
            return new Potion
            {
                Id = ID,
                Name = "Truesight Potion",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("279667d8-e6ff-4072-90a3-9d83609418d5"), "Upon drinking this clear, refreshing potion, you can see things as they actually are.");
        }

        protected override IEnumerable<PotionVariant> GetPotionVariants()
        {
            yield return new PotionVariant
            {
                Id = Guid.Parse("868261df-d1d9-43f9-b499-1427c136c45c"),
                Name = "Truesight Potion",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 16,
                Price = 150000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("9acc699a-edbe-42d3-8282-92547bc05a6d"), ActionTypes.Instances.OneAction.ID, "Activate", action => 
                    {
                        action
                            .Kind("Interact")
                            .Details(effect => 
                            {
                                effect.Text(Guid.Parse("437ad78e-6a35-41da-9351-ab75c0dc903e"), "You gain the benefits of a 7th-level true seeing spell that has a counteract modifier of +25.");
                            });
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("2adbe26a-7724-41e4-b95a-07b9bddb71d3"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("518ff225-a97f-4005-9b45-36e71c0beff8"), Traits.Instances.Divination.ID);
            builder.Add(Guid.Parse("1a7abd4f-f93a-468b-abe6-6bb5780147b0"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("468a7873-1ef4-46e6-be56-7181d47677db"), Traits.Instances.Potion.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("471c71e2-bef3-43b5-befe-068a18b73110"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 564
            };
        }
    }
}
