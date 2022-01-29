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
    public class DruidsVestments : Template
    {
        public static readonly Guid ID = Guid.Parse("33e2291e-687c-4e91-953e-5475362b1f24");
        
        protected override WornItem GetWornItem()
        {
            return new WornItem
            {
                Id = ID, 
                Name = "Druid's Vestments",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("a2322574-2e9f-4b46-888c-daf79729500f"), "This brown-and-green tunic is embroidered with patterns that resemble interlocking elk antlers. You gain a +2 item bonus to Nature checks.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("114b5030-cde5-4189-9126-9bc983b3c030"), Traits.Instances.Focussed.ID);
            builder.Add(Guid.Parse("b523e0c9-9a2e-4f66-a0fa-260b69bb2ee1"), Traits.Instances.Invested.ID);
            builder.Add(Guid.Parse("79736f73-74f5-4008-b4a0-571aae8fa557"), Traits.Instances.Primal.ID);
            builder.Add(Guid.Parse("bafd8809-644e-49ff-b001-fb35d785050e"), Traits.Instances.Transmutation.ID);
        }

        protected override IEnumerable<WornItemVariant> GetWornItemVariants()
		{
			yield return new WornItemVariant
			{
				Id = Guid.Parse("b5df3bcf-5460-49e9-a8af-3f9c5adb2c3d"),
				Name = "Druid's Vestments",
                Usage = "Worn garment.",
                CraftingRequirements = "You are a druid.",
                Level = 10,
				Price = 100000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("d7b7e5de-2700-4b0b-b8ee-3792fb267427"), ActionTypes.Instances.FreeAction.ID, name: "Activate", action =>
                    {
                        action
                            .Kind("Envision")
                            .Frequency("Once per day.")
                            .Details(builder =>
                            {
                                builder.Text(Guid.Parse("0bd62e1a-d706-408b-84f0-cae4216be6ae"), "You gain 1 Focus Point, which you can spend only to cast an order spell. If you don't spend this Focus Point by the end of this turn, it is lost.");
                            });
                    })
                    .Build()
			};
		}

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1d5295ed-91f9-43b9-8e68-01c52beeab5e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 610
            };
        }
    }
}
