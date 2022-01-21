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
    public class BeltOfTheFiveKings : Template
    {
        public static readonly Guid ID = Guid.Parse("25896194-ae73-4ca5-83c2-1d7b343a27ce");
        
        protected override WornItem GetWornItem()
        {
            return new WornItem
            {
                Id = ID, 
                Name = "Belt of the Five Kings",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("2d741247-a660-49ce-b010-dbe7c6bc2a5d"), "Made from interlocking plates of silver and gold, this heavy belt bears stylized miniature images of five kingly dwarves. You gain a +1 circumstance bonus to Diplomacy checks to Make an Impression with dwarves or make a Request from dwarves. You also gain a +1 circumstance bonus to Intimidation checks against giants and orcs.");
            builder.Text(Guid.Parse("52fb430e-33f7-4e9e-8d06-47731d133035"), "The belt also grants you darkvision and the ability to understand, speak, and write the Dwarven language");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("54e49d5a-75eb-4720-8b50-cff692da0a69"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("8504c43d-5735-4ae2-9186-7ab54b76d38c"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("6f2bf150-29c8-4323-8ac9-c08aa982f8f8"), Traits.Instances.Invested.ID);
            builder.Add(Guid.Parse("8970c693-776e-45ad-a60d-4a880c553fc6"), Traits.Instances.Magical.ID);
        }

        protected override IEnumerable<WornItemVariant> GetWornItemVariants()
		{
            yield return new WornItemVariant
            {
                Id = Guid.Parse("0388a403-ec16-4598-a755-d5a1f453d086"),
                Name = "Belt of the Five Kings",
                Usage = "Worn belt.",
                Level = 9,
                Price = 65000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("e4625229-902a-4bf3-a613-d0148630a09e"), ActionTypes.Instances.OneAction.ID, name: "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Requirements("You are a dwarf.")
                            .Frequency("Once per day.")
                            .Details(builder =>
                            {
                                builder.Text(Guid.Parse("f44e0b86-32ec-4a39-8c8d-dd4aecee65c5"), "You tightenthe belt one notch to gain temporary Hit Points equal to your level and grant allies within 20 feet of you darkvision. Both effects last for 10 minutes.");
                            });
                    })
                    .Build()
            };
		}

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0b6f2437-4cd9-4cf8-9361-7dce4eb06efc"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 606
            };
        }
    }
}
