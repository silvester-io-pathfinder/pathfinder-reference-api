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
    public class EyesOfTheEagle : Template
    {
        public static readonly Guid ID = Guid.Parse("b23aded0-a081-4a31-9b74-9ff7866221dc");
        
        protected override WornItem GetWornItem()
        {
            return new WornItem
            {
                Id = ID, 
                Name = "Eyes of the Eagle",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("4309f57b-621d-4b62-9082-b044a35c96b1"), "These lenses of amber crystal fit over your eyes. They grant you low-light vision and a +2 item bonus to Perception checks that involve sight.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("95ade139-361e-4964-a189-0eb5065b73ef"), Traits.Instances.Invested.ID);
            builder.Add(Guid.Parse("cc15523e-5e85-4c85-b38a-97194e0f693a"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("d7acdbf8-fed5-48d3-92bb-ad01d0335a54"), Traits.Instances.Transmutation.ID);
        }

        protected override IEnumerable<WornItemVariant> GetWornItemVariants()
		{
			yield return new WornItemVariant
			{
				Id = Guid.Parse("8ed022db-f526-4bd7-b104-74bd4b2c41f5"),
				Name = "Eyes of the Eagle",
                Usage = "Worn eyepiece.",
				Level = 9,
				Price = 70000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
			};
		}

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e98fc80d-bf45-4858-adb7-3db90eda0476"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 610
            };
        }
    }
}
