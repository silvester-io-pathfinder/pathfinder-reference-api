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
    public class RingOfSustenance : Template
    {
        public static readonly Guid ID = Guid.Parse("0729b0bf-643a-495e-aede-0e562dbf60f5");
        
        protected override WornItem GetWornItem()
        {
            return new WornItem
            {
                Id = ID, 
                Name = "Ring of Sustenance",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("f4449656-6522-4cf8-8d48-0642dc2a39b6"), "This polished wooden ring constantly refreshes your body and mind. You don�t need to eat or drink while wearing it, and you need only 2 hours of sleep per day to gain the benefits of 8 hours of sleep. A ring of sustenance doesn�t function until it�s been worn and invested continuously for a week. Removing it resets this interval.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("68783444-fab0-4c83-b086-1be9a788fb6a"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("ef99f2b0-0b22-40af-bcea-8de890ae4485"), Traits.Instances.Conjuration.ID);
            builder.Add(Guid.Parse("fd05a87b-3e4a-4414-a9fd-7eb2c10311af"), Traits.Instances.Invested.ID);
            builder.Add(Guid.Parse("294ef28b-f6d2-4fdf-ac79-cc8621bd3f60"), Traits.Instances.Magical.ID);
        }

        protected override IEnumerable<WornItemVariant> GetWornItemVariants()
		{
			yield return new WornItemVariant
			{
				Id = Guid.Parse("93578df1-1c05-42fb-96aa-c903b20a2476"),
				Name = "Ring of Sustenance",
                Usage = "Worn.",
				Level = 7,
				Price = 32500,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
			};
		}

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8420c447-f94a-4d51-ab7f-08970aee0cca"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 615
            };
        }
    }
}
