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
    public class BardingOfTheZephyr : Template
    {
        public static readonly Guid ID = Guid.Parse("fde3e5cf-9263-4a4b-aef9-bfae40cbaa94");
        
        protected override WornItem GetWornItem()
        {
            return new WornItem
            {
                Id = ID, 
                Name = "Barding of the Zephyr",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("6c512678-fb79-4453-8d24-1f3aa49a816b"), "This light barding is covered in stylized wind motifs. When you suit up your animal companion, the barding adjusts to fit your animal companion regardless of its shape.");
            builder.Text(Guid.Parse("531014cb-4532-4333-9a1a-02cef0fab219"), "When your companion falls, wind picks it up from below; it gains the effects of feather fall.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("2c062a8d-956c-4f3f-8e62-88f36e6d0ba3"), Traits.Instances.Companion.ID);
            builder.Add(Guid.Parse("9b55a9da-cb6e-44b2-a390-bf7333b7da86"), Traits.Instances.Invested.ID);
            builder.Add(Guid.Parse("24ab34d2-2828-411b-8296-e4b882f52a79"), Traits.Instances.Primal.ID);
            builder.Add(Guid.Parse("1cc1d800-aafd-408a-a9d1-f20c015cbba7"), Traits.Instances.Transmutation.ID);
        }

        protected override IEnumerable<WornItemVariant> GetWornItemVariants()
		{
			yield return new WornItemVariant
			{
				Id = Guid.Parse("52bf4686-c2c8-4d63-ac5c-58680bb92a82"),
				Name = "Barding of the Zephyr",
				Usage = "Worn barding.",
				Level = 10,
				Price = 90000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("a0c741d3-cfe1-488f-9f26-fefa79dc62a7"), ActionTypes.Instances.TwoActions.ID, name: "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Frequency("Once per day.")
                            .Details(builder =>
                            {
                                builder.Text(Guid.Parse("f22678d0-6db2-4c5e-bef2-d0b1c75d3819"), "You trace a finger along the wind motifs on the barding, granting your companion wearing the barding a fly Speed of 30 feet for 10 minutes. Even if the companion doesn't have the mount special ability, it can still Fly while being ridden.");
                            });
                    })
                    .Build()
			};
		}

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b91df7bf-1565-424d-b540-e879a19aad4f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 604 
            };
        }
    }
}
