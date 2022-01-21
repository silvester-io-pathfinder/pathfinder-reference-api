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
    public class ChokerOfElocution : Template
    {
        public static readonly Guid ID = Guid.Parse("a5e82d89-ad7c-4ba8-ba83-e08b8cc039bc");
        
        protected override WornItem GetWornItem()
        {
            return new WornItem
            {
                Id = ID, 
                Name = "Choker of Elocution",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("3fb9fa3e-d64f-455c-9251-7417d269d1d8"), "This platinum choker bears characters from a language�s alphabet, and it gives knowledge of that language and the associated culture�s customs. You gain a +1 item bonus to Society checks and the ability to understand, speak, and write the chosen language. Your excellent elocution reduces the DC of the flat check to perform an auditory action while deafened from 5 to 3.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("43e71be8-3ebb-4c21-b04a-5f4b5b98bd88"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("f7afdf60-2761-4bf9-a7ba-dbc082d2df8a"), Traits.Instances.Invested.ID);
            builder.Add(Guid.Parse("6da8f55a-7b58-4dc6-8aba-8f569bf464c7"), Traits.Instances.Magical.ID);
        }

        protected override IEnumerable<WornItemVariant> GetWornItemVariants()
        {
            yield return new WornItemVariant
            {
                Id = Guid.Parse("136676fc-5e22-4591-b260-bbf6030349b8"),
                Name = "Choker of Elocution",
                CraftingRequirements = "You know the language or languages the choker grants.",
                Usage = "Worn collar.",
                Level = 6,
                Price = 20000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };

            yield return new WornItemVariant
            {
                Id = Guid.Parse("5686878b-bd1d-491e-b0fc-3ef6182fd95e"),
                Name = "Choker of Elocution (Greater)",
                CraftingRequirements = "You know the language or languages the choker grants.",
                Usage = "Worn collar.",
                Level = 10,
                Price = 85000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("237cec46-8d9a-4700-a46b-bb18bcbc585c"), "The item bonus is +2. The choker bears characters from three languages and grants fluency in all three.")
                    .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("dd45af4f-e171-4726-9161-e2fed65b713a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 608
            };
        }
    }
}
