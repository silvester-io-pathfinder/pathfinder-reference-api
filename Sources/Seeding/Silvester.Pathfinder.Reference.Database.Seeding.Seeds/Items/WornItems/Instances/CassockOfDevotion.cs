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
    public class CassockOfDevotion : Template
    {
        public static readonly Guid ID = Guid.Parse("d5c22ba7-fc98-48aa-99b0-9c4ca8e3ea9c");
        
        protected override WornItem GetWornItem()
        {
            return new WornItem
            {
                Id = ID, 
                Name = "Cassock of Devotion",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("e71434a2-6ac6-4e9f-ad7f-f6efc0a86f8e"), "Each cassock of devotion depicts scenes related to the domains of a certain deity. It serves as a religious symbol of that deity, and it doesn't need to be wielded to provide that benefit. You gain a +2 item bonus to Religion checks and a +1 item bonus to the divine skill of the deity to whom the cassock is dedicated (as listed on pages 437-440).");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("195c7f37-e547-4314-8e1c-b75ec8bd2f39"), Traits.Instances.Divination.ID);
            builder.Add(Guid.Parse("799d0ec7-0bd4-4025-af3b-0b73cbab796d"), Traits.Instances.Divine.ID);
            builder.Add(Guid.Parse("0c6cd071-8065-459a-94eb-8af393dca14b"), Traits.Instances.Focussed.ID);
            builder.Add(Guid.Parse("94ec1c38-4fd0-442b-b149-41fcc37c20cb"), Traits.Instances.Invested.ID);
        }

        protected override IEnumerable<WornItemVariant> GetWornItemVariants()
		{
			yield return new WornItemVariant
			{
				Id = Guid.Parse("1ae9569e-11e1-4132-8084-8872c81539ec"),
				Name = "Cassock of Devotion",
                Usage = "Worn garment.",
                CraftingRequirements = "You are a cleric who worships the deity tied to the cassock.",
                Level = 11,
				Price = 115000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("ff1b2576-3077-425a-a95b-7bce9a045d3d"), ActionTypes.Instances.FreeAction.ID, name: "Activate", action =>
                    {
                        action
                            .Kind("Envision")
                            .Frequency("Once per day.")
                            .Details(builder =>
                            {
                                builder.Text(Guid.Parse("dd706203-bdd1-45ae-b2c2-a443cf58b732"), "Gain 1 Focus Point, which you can spend only to cast a cleric domain spell for a domain belonging to the deity the cassock is dedicated to. If you don't spend this point by the end of this turn, it is lost.");
                            });
                    })
                    .Build()
			};
		}

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8c373a70-930f-4858-9e98-727338a43d6b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 607
            };
        }
    }
}
