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
    public class RingOfSwimming : Template
    {
        public static readonly Guid ID = Guid.Parse("721e19e6-7c2f-490e-97bc-84b09e061198");
        
        protected override WornItem GetWornItem()
        {
            return new WornItem
            {
                Id = ID, 
                Name = "Ring of Swimming",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("f6db3786-119b-4795-af1b-61d398e66c00"), "This blue metal ring grants you a swim Speed equal to half your land Speed. Penalties to your Speed (including from your armor) apply before halving.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("f9ff0ec3-f8ef-4252-84d4-02a6f8e60788"), Traits.Instances.Invested.ID);
            builder.Add(Guid.Parse("97c64203-8b2f-4d12-8fdc-ca1a3e3eddd6"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("d748223c-4e1b-407a-8e59-2b3b0d49fc80"), Traits.Instances.Transmutation.ID);
        }

        protected override IEnumerable<WornItemVariant> GetWornItemVariants()
		{
			yield return new WornItemVariant
			{
				Id = Guid.Parse("6ad68ed7-7361-44f6-8251-58489b69a3d7"),
				Name = "Ring of Swimming",
                Usage = "Worn.",
				Level = 12,
				Price = 175000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
			};
		}

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d6cee87d-67b3-4c32-a4a3-bf3adf1e0958"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 615
            };
        }
    }
}
