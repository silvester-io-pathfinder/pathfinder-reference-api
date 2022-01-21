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
    public class ChannelProtectionAmulet : Template
    {
        public static readonly Guid ID = Guid.Parse("7a735c6c-ac49-4eda-a4a8-6b29ff81dd9d");
        
        protected override WornItem GetWornItem()
        {
            return new WornItem
            {
                Id = ID, 
                Name = "Channel Protection Amulet",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("d6d48f01-610f-44ac-bc79-33b74021da07"), "This nugget of polished tektite is trapped in a cage of braided wire and hangs from a silken cord. When wearing this amulet, you gain resistance 5 against damage from harm spells if you�re living, or against heal spells if you�re undead.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("9a7047b4-336a-4c4e-8a26-ed2154c75030"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("95c53e8b-843b-448a-9001-b0643ca202cc"), Traits.Instances.Abjuration.ID);
            builder.Add(Guid.Parse("6ee485d0-1545-4188-9f96-286e8a16a89d"), Traits.Instances.Invested.ID);
            builder.Add(Guid.Parse("723737f0-ad07-4df0-af62-11e6952fd3c7"), Traits.Instances.Magical.ID);
        }

        protected override IEnumerable<WornItemVariant> GetWornItemVariants()
		{
			yield return new WornItemVariant
			{
				Id = Guid.Parse("e562e5f4-31df-496f-8d34-c85e02c81c01"),
				Name = "Channel Protection Amulet",
                Usage = "Worn.",
                Level = 3,
				Price = 5600,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
			};
		}

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("db27dec5-f2ae-4264-a784-40bee7cd170e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 607
            };
        }
    }
}
