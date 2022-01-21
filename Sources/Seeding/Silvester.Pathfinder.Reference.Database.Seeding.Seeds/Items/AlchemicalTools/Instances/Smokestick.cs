using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Actions.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AlchemicalTools.Instances
{
    public class Smokestick : Template
    {
        public static readonly Guid ID = Guid.Parse("3c31b16b-1804-4e2e-ba66-9bb8faaca03e");

        protected override AlchemicalTool GetAlchemicalTool()
        {
            return new AlchemicalTool
            {
                Id = ID,
                Name = "Smokestick",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("9908505d-e79b-42e7-8f5a-dd4ec3165054"), "A wooden stick, treated alchemically to create an opaque smoke.");;
        }

        protected override IEnumerable<AlchemicalToolVariant> GetAlchemicalToolVariants()
        {
            yield return new AlchemicalToolVariant
            {
                Id = Guid.Parse("44ea3349-f059-4d50-ab21-6076b0d3a05a"),
                Name = "Smokestick (Lesser)",
                Level = 1,
                Price = 300,
                Usage = "Held in 2 hands",
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("80c3e4a0-3d91-4a8f-aa5d-30aa3e1afbfc"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("72118508-d133-4443-a90a-821ec4a486c7"), "With a sharp twist of this item, you instantly create a screen of thick, opaque smoke in a 5-foot burst centered on one corner of your space. All creatures within that area are concealed, and all other creatures are concealed to them. The smoke lasts for 1 minute or until dispersed by a strong wind.");
                            });
                    })
                    .Build(),
            };

            yield return new AlchemicalToolVariant
            {
                Id = Guid.Parse("21dc61b1-76f2-437e-9475-e2ab515c606f"),
                Name = "Smokestick (Greater)",
                Level = 7,
                Price = 5300,
                Usage = "Held in 2 hands",
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("148e68f4-caaa-463e-a3ec-f19013c82cf1"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("2679a8b2-5a92-48b7-8484-117ce1a5dda3"), "With a sharp twist of this item, you instantly create a screen of thick, opaque smoke in a 20-foot burst centered on one corner of your space. All creatures within that area are concealed, and all other creatures are concealed to them. The smoke lasts for 1 minute or until dispersed by a strong wind.");
                            });
                    })
                    .Build(),
            };

        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("b3877789-695f-49a3-a68e-998a7641dce3"), Traits.Instances.Alchemical.ID);
            builder.Add(Guid.Parse("866afa2b-f42b-440c-a2bb-88fa62e91c4c"), Traits.Instances.Consumable.ID);
        }

        protected override SourcePage? GetSourcePage()
        {
            return new SourcePage 
            {
                Id = Guid.Parse("fadcc111-0da1-42d0-b68d-80a65ab516dd"),
                SourceId = CoreRulebook.ID,
                Page = 554
            };
        }

    }
}
