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
    public class GlovesOfStoring : Template
    {
        public static readonly Guid ID = Guid.Parse("f116c745-47b8-40f9-9eee-7dd18c845e78");
        
        protected override WornItem GetWornItem()
        {
            return new WornItem
            {
                Id = ID, 
                Name = "Gloves of Storing",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("35c65cf7-45fc-4066-ac33-ba3d8f5e2880"), "An item can be stored inside these supple leather gloves, held in an extradimensional space. When an item is inside the glove, an image of the item appears as a simple, stitched pattern on the back of each glove. Many gloves of storing are found with an item already inside.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("7dfb19d1-9472-4f37-8775-3621c0a82242"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("7aa7f3b8-3c60-430f-84ec-85d63fda3e88"), Traits.Instances.Extradimensional.ID);
            builder.Add(Guid.Parse("c9f507fe-d932-438e-986c-bbc3c0c3340b"), Traits.Instances.Invested.ID);
            builder.Add(Guid.Parse("ecf8800c-58d6-4da2-bd1b-16b31ce8147a"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("257eeed9-5c6e-4f2b-b3f1-be1ea73e5bf2"), Traits.Instances.Transmutation.ID);
        }

        protected override IEnumerable<WornItemVariant> GetWornItemVariants()
		{
			yield return new WornItemVariant
			{
				Id = Guid.Parse("16efb9d1-d773-4319-a757-e50c162025a0"),
				Name = "Gloves of Storing",
                Usage = "Worn gloves.",
				Level = 7,
				Price = 34000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("7e5c73bd-1a99-4739-8dde-5222bd160011"), ActionTypes.Instances.OneAction.ID, name: "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Requirements("No item is stored in the gloves.")
                            .Details(builder =>
                            {
                                builder.Text(Guid.Parse("0578ad48-fc46-49a8-9d44-6a3936e7e079"), "One item you�re holding with a Bulk of 1 or less vanishes into the gloves� extradimensional space.");
                            });
                    })
                    .Add(Guid.Parse("83afe242-4856-4493-bf98-2a942a17cab1"), ActionTypes.Instances.FreeAction.ID, name: "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Frequency("Once per minute.")
                            .Requirements("An item is stored in the gloves, and you have a free hand.")
                            .Details(builder =>
                            {
                                builder.Text(Guid.Parse("4e349f6c-87cb-43aa-b697-90898d8750f5"), "The item stored in the gloves appears in your hand. The gloves can�t be activated again for 1 minute.");
                            });
                    })
                    .Build()
			};
		}

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b4f3a442-362c-49bc-a90e-e8fe32890ac5"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 610
            };
        }
    }
}
