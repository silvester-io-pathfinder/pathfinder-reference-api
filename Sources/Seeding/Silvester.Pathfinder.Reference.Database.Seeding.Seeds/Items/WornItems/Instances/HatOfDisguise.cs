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
    public class HatOfDisguise : Template
    {
        public static readonly Guid ID = Guid.Parse("0b567709-ac1b-492a-b145-4893e73dfa55");
        
        protected override WornItem GetWornItem()
        {
            return new WornItem
            {
                Id = ID, 
                Name = "Hat of Disguise",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("32cfea1c-a01b-4a82-b315-a5c65189e80c"), "This ordinary-looking hat allows you to cloak yourself in illusions.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("b99ef346-1e71-41b3-9ca5-0806fb8fbbed"), Traits.Instances.Illusion.ID);
            builder.Add(Guid.Parse("ced10286-7d20-49b7-a7cd-d587211edb32"), Traits.Instances.Invested.ID);
            builder.Add(Guid.Parse("25d3455f-2603-4bab-9bc1-da53c3f715bf"), Traits.Instances.Magical.ID);
        }

        protected override IEnumerable<WornItemVariant> GetWornItemVariants()
        {
            yield return new WornItemVariant
            {
                Id = Guid.Parse("2cc27371-717f-421c-a85a-a40d50904f32"),
                Name = "Hat of Disguise",
                Usage = "Worn headwear.",
                Level = 2,
                Price = 3000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("21cf9f29-d1c0-46de-9807-bc5c14c9907d"), ActionTypes.Instances.NoAction.ID, name: "Activate", action =>
                    {
                        action
                            .Kind("1 minute (Interact)")
                            .Frequency("Once per day.")
                            .Details(builder =>
                            {
                                builder.Text(Guid.Parse("de44b2c7-c23f-4e47-9a20-59efe839634e"), "The hat casts a 1st-level illusory disguise spell on you. While setting up the disguise, you can magically alter the hat to appear as a comb, ribbon, helm, or other piece of headwear.");
                            });
                    })
                    .Build()
            };

            yield return new WornItemVariant
            {
                Id = Guid.Parse("fc253a2e-117f-4c7f-8b82-c0a1c93ad5a2"),
                Name = "Hat of Disguise (Greater)",
                Usage = "Worn headwear.",
                Level = 7,
                Price = 34000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                     .Text(Guid.Parse("b96c2d85-73f5-4c7a-9476-9861deb2ff4c"), "You can activate the hat as a 2-action activity, you can activate it any number of times per day, and the illusory disguise is 2nd level.")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                     .Add(Guid.Parse("2ef9aaba-9d15-4b01-b623-cddd65052495"), ActionTypes.Instances.TwoActions.ID, name: "Activate", action =>
                     {
                         action
                             .Kind("1 minute (Interact)")
                             .Details(builder =>
                             {
                                 builder.Text(Guid.Parse("8bea5cb6-3a3c-41b3-8869-a3f9a3525c59"), "The hat casts a 2nd-level illusory disguise spell on you. While setting up the disguise, you can magically alter the hat to appear as a comb, ribbon, helm, or other piece of headwear.");
                             });
                     })
                    .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("09602636-a1f9-44db-aa83-efb3b8fdd128"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 611
            };
        }
    }
}
