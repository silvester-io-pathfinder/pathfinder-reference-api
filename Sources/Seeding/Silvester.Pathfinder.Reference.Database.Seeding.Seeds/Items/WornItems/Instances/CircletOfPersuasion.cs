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
    public class CircletOfPersuasion : Template
    {
        public static readonly Guid ID = Guid.Parse("704344a3-eebc-4061-aa1e-4686beab9531");
        
        protected override WornItem GetWornItem()
        {
            return new WornItem
            {
                Id = ID, 
                Name = "Circlet of Persuasion",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("875ad050-d6b3-4d4e-98f8-fa00083920e2"), "This elegant silver band often resembles curling fig leaves and fits around your brow. You gain a +2 item bonus to Deception and Diplomacy checks. When you invest the circlet, you either increase your Charisma score by 2 or increase it to 18, whichever would give you a higher score.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("3a61a5f6-99bd-4ea0-8e59-dc4f0dff17ed"), Traits.Instances.Apex.ID);
            builder.Add(Guid.Parse("488637b1-bfdc-4605-9624-3108a56b7d46"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("81bd65b0-a540-4366-9414-c622fb14a2f3"), Traits.Instances.Invested.ID);
            builder.Add(Guid.Parse("c778ce3f-fd2f-4978-9be2-4f02905cfa79"), Traits.Instances.Magical.ID);
        }

        protected override IEnumerable<WornItemVariant> GetWornItemVariants()
		{
			yield return new WornItemVariant
			{
				Id = Guid.Parse("4dd790a2-0a45-434e-822e-bdc93a988099"),
				Name = "Circlet of Persuasion",
                Usage = "Worn circlet.",
				Level = 17,
				Price = 1500000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("8000a810-a0fa-4751-be3a-3773c614635f"), ActionTypes.Instances.TwoActions.ID, name: "Activate", action =>
                    {
                        action
                            .Kind("Envision")
                            .Frequency("Once per hour.")
                            .Details(builder =>
                            {
                                builder.Text(Guid.Parse("403d1bfb-48b8-4235-966c-54acb2402d68"), "You case a 4th-level charm spell (DC 38).");
                            });
                    })
                    .Build()
			};
		}

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ade094fd-7009-4024-b6d7-6e860f9284ad"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 603
            };
        }
    }
}
