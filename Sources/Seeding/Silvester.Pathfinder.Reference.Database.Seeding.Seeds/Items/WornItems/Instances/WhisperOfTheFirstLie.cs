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
using Silvester.Pathfinder.Reference.Database.Models.Items;


namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.WornItems.Instances
{
    public class WhisperOfTheFirstLie : Template
    {
        public static readonly Guid ID = Guid.Parse("f8afdae1-3680-49e7-bbc9-d0a5eda9678e");
        
        protected override WornItem GetWornItem()
        {
            return new WornItem
            {
                Id = ID, 
                Name = "Whisper of the First Lie"
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("5f9a5335-4411-45b4-83c6-1e7de54fb6e0"), "This delicate necklace contains bottled whispers distilled from a source on the Astral Plane rumored to be connected to the first lie ever told. While wearing the necklace, you gain a +3 item bonus to Deception checks, and you can attempt to counteract effects that would force you to tell the truth or determine whether you are lying. Success on this counteract attempt lets you ignore the effect, rather than removing the effect entirely. The counteract level is 9, with a counteract modifier of +35.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("f74e236d-a9ff-4e32-82e9-9e3dfc790112"), Traits.Instances.Rare.ID);
            builder.Add(Guid.Parse("31231f7f-8eed-45eb-884a-aaa548afaed7"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("9b333437-9e5c-4558-8c8d-d9fa30e6442a"), Traits.Instances.Invested.ID);
            builder.Add(Guid.Parse("c85ef04d-8502-47b1-a49f-62afa0d7e398"), Traits.Instances.Magical.ID);
        }

        protected override IEnumerable<WornItemVariant> GetWornItemVariants()
		{
			yield return new WornItemVariant
			{
				Id = Guid.Parse("675ac030-2a8d-4b0f-9610-3ec072b11d9e"),
				Name = "Whisper of the First Lie",
                Usage = "Worn.",
                CraftingRequirements = "Supply a casting of Fabricated Truth.",
				Level = 20,
				Price = 6000000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Rare.ID,
                InlineActions = new InlineActionCollectionBuilder()
                     .Add(Guid.Parse("7f1bcbef-eb0f-4082-824d-d4ae77bf04c0"), ActionTypes.Instances.ThreeActions.ID, name: "Activate", action =>
                     {
                         action
                             .Kind("Interact, Envision, Command")
                             .Details(builder =>
                             {
                                 builder.Text(Guid.Parse("218bcdae-4ac5-46d4-b187-38402210167d"), "You unstopper the vial and release the lie, creating the effect of a fabricated truth (DC 47). The vial is emptied and can never be activated again.");
                             });
                     })
                    .Build()
			};
		}
            
        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("91b53990-1831-44be-9e8f-9ae02f3f4de8"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 617
            };
        }
    }
}
