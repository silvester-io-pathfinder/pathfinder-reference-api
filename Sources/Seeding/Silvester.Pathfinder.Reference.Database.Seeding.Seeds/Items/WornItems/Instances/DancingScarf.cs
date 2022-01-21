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
    public class DancingScarf : Template
    {
        public static readonly Guid ID = Guid.Parse("2243108b-1e26-49d3-9e55-8cf482d95b52");
        
        protected override WornItem GetWornItem()
        {
            return new WornItem
            {
                Id = ID, 
                Name = "Dancing Scarf",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("8ae05332-beb6-4efc-a54f-3071a3a4b4f6"), "This long and billowing scarf is typically woven of silk or sheer fabric and adorned with bells or other jangling bits of shiny metal. It grants a +1 item bonus to Performance checks to dance.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("551a4ba8-6a09-4d3b-bc9c-1a6d8ba9f405"), Traits.Instances.Illusion.ID);
            builder.Add(Guid.Parse("a43e5ceb-1625-449a-abfb-f361445dbe82"), Traits.Instances.Invested.ID);
            builder.Add(Guid.Parse("a3ed1fa0-33be-4a26-b84a-993370a0701b"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("ce3f6c02-32de-43cb-adb0-50c9c71bc4e4"), Traits.Instances.Visual.ID);
        }

        protected override IEnumerable<WornItemVariant> GetWornItemVariants()
        {
            yield return new WornItemVariant
            {
                Id = Guid.Parse("b253f8c8-dfbf-4ec7-ae36-9f0994352ec8"),
                Name = "Dancing Scarf",
                Usage = "Worn belt.",
                Level = 3,
                Price = 60,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("15d32413-e3b6-46b4-885d-aff4abe8b0bc"), ActionTypes.Instances.OneAction.ID, name: "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Requirements("On your most recent action you succeeded at a Performance check to dance.")
                            .Details(builder =>
                            {
                                builder.Text(Guid.Parse("f3aa197a-d6c8-4142-b0fc-5bc2b92cacbd"), "You become concealed until the beginning of your next turn.");
                            });
                    })
                    .Build()
            };

            yield return new WornItemVariant
            {
                Id = Guid.Parse("5c02c306-b740-4539-9d14-0249cb47625d"),
                Name = "Dancing Scarf (Greater)",
                Usage = "Worn belt.",
                Level = 9,
                Price = 65000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("d02864bf-e804-4d8e-b409-84b5379cdefa"), "The scarf grants a +2 bonus. When you activate the scarf, you can also Stride up to half your Speed or Step.")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("7bbd62dd-28e1-445c-8651-7bc458e88dc5"), ActionTypes.Instances.OneAction.ID, name: "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Requirements("On your most recent action you succeeded at a Performance check to dance.")
                            .Details(builder =>
                            {
                                builder.Text(Guid.Parse("de28d140-4c7b-4cab-acf0-92c2f05401df"), "You become concealed until the beginning of your next turn.");
                            });
                    })
                    .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("add11647-e1ca-4478-81fb-40e3e16a43df"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 609
            };
        }
    }
}
