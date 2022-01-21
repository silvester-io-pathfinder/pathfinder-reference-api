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
    public class RingOfClimbing : Template
    {
        public static readonly Guid ID = Guid.Parse("98ff323b-d720-4b68-8db7-6be95c342be4");
        
        protected override WornItem GetWornItem()
        {
            return new WornItem
            {
                Id = ID, 
                Name = "Ring of Climbing",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("c6995d45-7f25-45a9-9353-7f272feddc46"), "Claw-like prongs on his thick golden band bears extend to dig deep into sheer surfaces when you are Climbing. This ring grants you a climb Speed equal to half your land Speed. Penalties to your Speed (including those from your armor) apply before halving.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("08c7c608-9546-488f-8822-4152d5d68572"), Traits.Instances.Invested.ID);
            builder.Add(Guid.Parse("4553fd30-5863-4e52-9ec1-9c66ab79b116"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("d76e2572-9535-47a8-a2e0-8e8b5231ee2f"), Traits.Instances.Transmutation.ID);
        }

        protected override IEnumerable<WornItemVariant> GetWornItemVariants()
		{
			yield return new WornItemVariant
			{
				Id = Guid.Parse("f8601d52-421a-4f74-a558-32852617e06c"),
				Name = "Ring of Climbing",
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
                Id = Guid.Parse("67538766-d3a6-44cd-862b-7808021ef1e8"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 614
            };
        }
    }
}
