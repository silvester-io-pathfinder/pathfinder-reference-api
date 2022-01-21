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
    public class ThirdEye : Template
    {
        public static readonly Guid ID = Guid.Parse("92ed69c1-7bb9-43ad-b3cc-c5f7116ecfb6");
        
        protected override WornItem GetWornItem()
        {
            return new WornItem
            {
                Id = ID, 
                Name = "Third Eye",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("4891f0ce-e518-4bcc-83c9-a24cda3bb470"), "When invested, this ornate crown and its incandescent gemstone meld into your head and take the form of a tattoo. This grants you otherworldly sight and allows you to read auras. No one but you can manipulate the third eye while it�s invested by you. Your heightened senses and ability to sense emotional auras grant you a +3 item bonus to Perception checks.");
            builder.Text(Guid.Parse("b71652b2-9289-4961-87e5-f58a6846b469"), "You continuously see magic auras, as a 9thlevel detect magic spell, except you see the location of all auras within 30 feet, not just the strongest. If you use a Seek action to study a creature you can see, you can perceive an aura that conveys knowledge of that creature�s health, including all conditions and afflictions it has and an approximate percentage of its remaining Hit Points.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("bbf61a1c-01b6-4fa0-a000-ed2080f3c36b"), Traits.Instances.Divination.ID);
            builder.Add(Guid.Parse("26209683-2502-4253-ba63-294ab20865a9"), Traits.Instances.Invested.ID);
            builder.Add(Guid.Parse("72540a8d-4a81-46c8-8d91-dd078e506334"), Traits.Instances.Magical.ID);
        }

        protected override IEnumerable<WornItemVariant> GetWornItemVariants()
		{
			yield return new WornItemVariant
			{
				Id = Guid.Parse("7b631bc6-71c6-4af4-8399-b6a4826ea70d"),
				Name = "Third Eye",
                Usage = "Worn.",
				Level = 19,
				Price = 4000000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("33c8123d-ca2c-4cbf-975b-3f4e380e1907"), ActionTypes.Instances.TwoActions.ID, name: "Activate", action =>
                    {
                        action
                            .Kind("Envision")
                            .Frequency("Once per day.")
                            .Details(builder =>
                            {
                                builder.Text(Guid.Parse("fe77a5d9-c873-4677-982e-80cd5189a267"), "You gain the effects of an 8th-level True Seeing spell.");
                            });
                    })
                    .Build()
			};
		}

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b390aeb3-2d2c-4586-b325-7cfc5c9bf5f6"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 616
            };
        }
    }
}
