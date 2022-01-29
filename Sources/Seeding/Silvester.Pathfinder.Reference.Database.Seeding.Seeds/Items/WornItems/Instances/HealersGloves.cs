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
    public class HealersGloves : Template
    {
        public static readonly Guid ID = Guid.Parse("4a56b6d5-897a-422e-8fe5-9694dd45fd3b");
        
        protected override WornItem GetWornItem()
        {
            return new WornItem
            {
                Id = ID, 
                Name = "Healer's Gloves",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("bebd40a7-0ae8-4ef6-9bf9-58cec5e79c45"), "These clean, white gloves never show signs of blood, even when used to stitch up wounds or treat other ailments. They give you a +1 item bonus to Medicine checks.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("c8445666-d8b9-41ac-8602-2d0dbdad4987"), Traits.Instances.Invested.ID);
            builder.Add(Guid.Parse("942c6c48-664d-428b-b3c6-b5ea8537ba60"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("a832bad0-7e50-4fae-81ec-ee6e92450853"), Traits.Instances.Necromancy.ID);
        }

        protected override IEnumerable<WornItemVariant> GetWornItemVariants()
        {
            yield return new WornItemVariant
            {
                Id = Guid.Parse("de09defa-ac7d-420b-a1de-feae567f7172"),
                Name = "Healer's Gloves",
                Usage = "Worn gloves.",
                Level = 4,
                Price = 8000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("426c5bd9-8658-4669-a09b-df9786b44a67"), ActionTypes.Instances.OneAction.ID, name: "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Frequency("Once per day.")
                            .Details(builder =>
                            {
                                builder.Text(Guid.Parse("4e4a6ca3-1d76-4294-90a1-7ae4d0bdf2eb"), "You can soothe the wounds of a willing, living, adjacent creature, restoring 2d6+7 Hit Points to that creature. This is a positive healing effect. You can't harm undead with this healing.");
                            });
                    })
                    .Build()
            };

            yield return new WornItemVariant
            {
                Id = Guid.Parse("94bb9763-19bc-40cb-b255-a654b7e2c6c1"),
                Name = "Healer's Gloves (Greater)",
                Usage = "Worn gloves.",
                Level = 9,
                Price = 70000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("74218788-5bfc-4270-86a9-1ec9ef05fc93"), "The gloves provide a +2 bonus and restore 4d6+15 Hit Points.")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("8180d9ca-d7f7-4879-9019-6a064c9bee5c"), ActionTypes.Instances.OneAction.ID, name: "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Frequency("Once per day.")
                            .Details(builder =>
                            {
                                builder.Text(Guid.Parse("d7b85661-d1cd-440c-a0d6-d56c1b9e29cb"), "You can soothe the wounds of a willing, living, adjacent creature, restoring 4d6+15 Hit Points to that creature. This is a positive healing effect. You can't harm undead with this healing.");
                            });
                    })
                    .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("292c8f9d-d7e8-4253-8ca8-80efeeecfdc9"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 612
            };
        }
    }
}
