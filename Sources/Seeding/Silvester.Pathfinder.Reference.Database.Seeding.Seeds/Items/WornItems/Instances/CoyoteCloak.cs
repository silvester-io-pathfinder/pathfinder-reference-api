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
    public class CoyoteCloak : Template
    {
        public static readonly Guid ID = Guid.Parse("cfcceb61-e670-4f07-af07-693346e7e8d0");
        
        protected override WornItem GetWornItem()
        {
            return new WornItem
            {
                Id = ID, 
                Name = "Coyote Cloak",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("abcb67e3-cc85-46f2-8d87-af7824cbfbdb"), "This dusty coat is made of mangy brown-and-gray coyote fur. You gain a + 1 item bonus to Survival checks.If you critically succeed at your Survival check to Subsist, you can feed twice as many additional creatures.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("a7d71229-0d49-4b9d-b811-4366302796a7"), Traits.Instances.Divination.ID);
            builder.Add(Guid.Parse("048be160-aabc-496c-9094-2c6ebeb942ce"), Traits.Instances.Invested.ID);
            builder.Add(Guid.Parse("60d3464d-062f-4e22-9346-36b41af782e3"), Traits.Instances.Magical.ID);
        }

        protected override IEnumerable<WornItemVariant> GetWornItemVariants()
        {
            yield return new WornItemVariant
            {
                Id = Guid.Parse("5daa5627-b8c5-4ed5-9b79-bf158f9d921f"),
                Name = "Coyote Cloak",
                Usage = "Worn cloak.",
                Level = 3,
                Price = 6000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };

            yield return new WornItemVariant
            {
                Id = Guid.Parse("39d12f53-3fe2-4fca-846e-c320ea248bc1"),
                Name = "Coyote Cloak (Greater)",
                Usage = "Worn cloak.",
                Level = 9,
                Price = 65000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("90369c1f-dd57-44d3-b717-45704e39798e"), "The cloak grants a +2 item bonus, and if you critically succeed at a Survival check to Subsist, you can feed four times as many additional creatures.")
                    .Build(),
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a31243fb-db9c-4ae6-824c-c7cf210428b6"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 609
            };
        }
    }
}
