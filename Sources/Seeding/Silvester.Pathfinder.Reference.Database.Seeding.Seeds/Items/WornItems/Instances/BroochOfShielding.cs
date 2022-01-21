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
    public class BroochOfShielding : Template
    {
        public static readonly Guid ID = Guid.Parse("0c6c18cd-be27-4841-896d-09cfe3da317c");
        
        protected override WornItem GetWornItem()
        {
            return new WornItem
            {
                Id = ID, 
                Name = "Brooch of Shielding",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("f3bb171e-eae7-4ae0-bd3a-4a4a10c917e8"), "This piece of silver or gold jewelry is adorned with miniature images of kite shields and can be used to fasten a cloak or cape. The brooch automatically absorbs magic missile spells targeting you. A brooch of shielding can absorb 30 individual magic missiles before it melts and becomes useless. Sometimes when found, a brooch of shielding has already absorbed a number of missiles.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("1c053449-9a28-4ee5-b517-f71fef109654"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("82551109-432b-44c3-bb76-19d8be62ed3b"), Traits.Instances.Abjuration.ID);
            builder.Add(Guid.Parse("96176968-60e3-4fb6-b531-4748fc9c8f44"), Traits.Instances.Invested.ID);
            builder.Add(Guid.Parse("f748e7df-a28b-46de-a01c-4bc547d4be1d"), Traits.Instances.Magical.ID);
        }

        protected override IEnumerable<WornItemVariant> GetWornItemVariants()
		{
			yield return new WornItemVariant
			{
				Id = Guid.Parse("f7bf68e3-1694-49b7-be27-5bd4ef5937e7"),
				Name = "Brooch of Shielding",
                Usage = "Worn.",
				Level = 2,
				Price = 3000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID
			};
		}

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e07c1b0b-986b-4fe3-b5a4-776ba48a35ba"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 607
            };
        }
    }
}
