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
    public class RingOfSpellTurning : Template
    {
        public static readonly Guid ID = Guid.Parse("dd76a3c4-aeaa-4a74-b244-8988a43ee60e");
        
        protected override WornItem GetWornItem()
        {
            return new WornItem
            {
                Id = ID, 
                Name = "Ring of Spell Turning",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("ca5e591c-2acf-4a52-9f4d-a7f1b9cc2f8c"), "This golden ring has three diamonds set into its face.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("70295eee-9e6d-4db0-ac53-c0615d448cf3"), Traits.Instances.Rare.ID);
            builder.Add(Guid.Parse("98803505-2451-44bd-8511-aaa943fd216b"), Traits.Instances.Abjuration.ID);
            builder.Add(Guid.Parse("c3b91d89-1655-4949-aa65-8906c09c666d"), Traits.Instances.Invested.ID);
            builder.Add(Guid.Parse("7cada7e6-7969-46e2-aabe-70347577f6a5"), Traits.Instances.Magical.ID);
        }

        protected override IEnumerable<WornItemVariant> GetWornItemVariants()
		{
			yield return new WornItemVariant
			{
				Id = Guid.Parse("984c3ad4-1c59-4bf9-a59c-15fc1e8fb710"),
				Name = "Ring of Spell Turning",
                Usage = "Worn.",
				Level = 20,
				Price = 6700000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Rare.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("9e5b13f8-d9a9-4745-ae08-0dbab5a00947"), ActionTypes.Instances.Reaction.ID, name: "Activate", action =>
                    {
                        action
                            .Kind("Envision")
                            .Trigger("You are targeted by a spell.")
                            .Details(builder =>
                            {
                                builder.Text(Guid.Parse("df25d171-5d6e-4637-813c-8d7f73bf2631"), "The ring replicates the effects of an 8th-level spell turning with a counteract modifier of +35, possibly causing the triggering spell to reflect back on its caster. The ring can reflect no more than 9 total levels of spells per day. If you activate the ring to reflect a spell that would exceed this limit, the attempt fails, but the attempted usage of the ring does not count toward the daily limit.");
                            });
                    })
                    .Build()
			};
		}

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a5bbd26f-e2d7-4ad7-8113-07f00fd12549"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 615
            };
        }
    }
}
