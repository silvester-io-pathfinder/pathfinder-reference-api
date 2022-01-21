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
    public class RobeOfEyes : Template
    {
        public static readonly Guid ID = Guid.Parse("a7bcc8c2-c8ac-4117-bcaf-f2ea13753726");
        
        protected override WornItem GetWornItem()
        {
            return new WornItem
            {
                Id = ID, 
                Name = "Robe of Eyes",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("9304cb26-75a7-4722-81f5-4ca43edfd0e9"), "This garment appears to be an ordinary robe until donned, at which point numerous strange and alien eyes of varied shapes and colors open and blink across its fabric. While wearing the robe, you gain a +3 item bonus to Perception checks, and you constantly benefit from the effects of a 2nd-level see Invisibility spell.");
            builder.Text(Guid.Parse("57969b9e-10f1-454a-b061-c1e362d7aed5"), "You can also see powerful magic auras. The highest-level magic aura within 30 feet of you glows in a color that reveals its school to you and allows you to determine where the effect originates. This can narrow down the origin point of the effect to a 5-foot-cube, but not more precisely than that.");
            builder.Text(Guid.Parse("c3c5a753-e6c1-479a-bd33-4b3aa4c3282e"), "The robe of eyes is not without its dangers. If any spell with the light trait is cast on you or your square while you are wearing the robe, you are blinded for a number of rounds equal to the spell�s level unless you succeed at a Fortitude save against the spell�s DC.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("f60a9021-2f8c-40b8-8641-1dff5fa4da58"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("5e349722-3060-4dda-821a-ded9f2fdd2ef"), Traits.Instances.Divination.ID);
            builder.Add(Guid.Parse("525186e1-a045-4b6b-aebe-dfc82d662fb4"), Traits.Instances.Invested.ID);
            builder.Add(Guid.Parse("3b8ed2ea-7c97-4764-a775-b85fe12289d3"), Traits.Instances.Magical.ID);
        }

        protected override IEnumerable<WornItemVariant> GetWornItemVariants()
		{
			yield return new WornItemVariant
			{
				Id = Guid.Parse("2762d5fa-81a1-4a77-8181-50d53154fc20"),
				Name = "Robe of Eyes",
                Usage = "Worn garment.",
				Level = 17,
				Price = 1300000,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("170c9ed7-b406-4880-b5de-6139bf7e9ed7"), ActionTypes.Instances.OneAction.ID, name: "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Details(builder =>
                            {
                                builder.Text(Guid.Parse("43c08a1f-8542-4ca6-b4d2-c0b152619435"), "You pluck an eye from the robe and toss it into the air, where it turns invisible and floats to a destination you choose, with the same effect as a 5th-level prying eye spell. You can Sustain the Activation just as you would be able to Sustain the Spell.");
                            });
                    })
                    .Build()
			};
		}

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b2aa4175-9a94-4626-a738-25e5f6b5d31b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 615
            };
        }
    }
}
