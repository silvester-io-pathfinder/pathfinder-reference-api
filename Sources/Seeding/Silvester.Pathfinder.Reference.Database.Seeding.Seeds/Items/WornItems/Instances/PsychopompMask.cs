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
    public class PsychopompMask : Template
    {
        public static readonly Guid ID = Guid.Parse("a65fe5d0-ac92-4bc8-9004-597fd4d870cf");
        
        protected override WornItem GetWornItem()
        {
            return new WornItem
            {
                Id = ID, 
                Name = "Psychopomp Mask"
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("eedb8073-eb92-43fe-a87a-c1d31babfd48"), "These minor magic items are painted to resemble your face, or some metaphorical depiction thereof, to encourage the ushers of death to take the mask in your place. If you begin your turn with a dying value of 3 or greater, instead of making your recovery check, you lose the dying condition but remain unconscious at 0 Hit Points. The mask then cracks in half and is destroyed. The psychopomps won't be so easily fooled again - you are temporarily immune to the effects of any psychopomp mask for 1 year.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("cb083a7e-6a18-4352-bc8a-d66d4248897a"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("060e4774-418d-4039-846b-12e2744e02ba"), Traits.Instances.Invested.ID);
            builder.Add(Guid.Parse("e45b6954-2bb1-41cd-b59c-271e48ed282b"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("3ed183ce-9607-44ab-be51-9bce9025b303"), Traits.Instances.Necromancy.ID);
        }

        protected override IEnumerable<WornItemVariant> GetWornItemVariants()
		{
			yield return new WornItemVariant
			{
				Id = Guid.Parse("8121e704-dfc6-47b2-a5c5-8c99d643cd30"),
				Name = "Psychopomp Mask",
                Usage = "Worn mask.",
				Level = 1,
				Price = 500,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
			};
		}
            
        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c8deb71a-d33d-411b-9db3-64048f8e8f35"),
                SourceId = Sources.Instances.Pathfinder169.ID,
                Page = 74
            };
        }
    }
}
