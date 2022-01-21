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
    public class ArmbandsOfAthleticism : Template
    {
        public static readonly Guid ID = Guid.Parse("01c455d7-33e2-4f79-9ad1-fc99b0f5015c");
        
        protected override WornItem GetWornItem()
        {
            return new WornItem
            {
                Id = ID, 
                Name = "Armbands of Athleticism",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("f5e9bb68-6efe-44db-b7fe-10d21e0cbe69"), "Skilled awl work has imprinted images of a muscled weightlifter into these tiered leather bands, which grant you enhanced stamina and skill when performing athletic exercises. While fastened to your upper arms, the armbands give you a +2 item bonus to Athletics checks. In addition, whenever you use an action to Climb or Swim and you succeed at the Athletics check, add a +5-foot item bonus to the distance you move.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("e5a1d893-0cbc-4bad-bb21-9ff25b596ef7"), Traits.Instances.Invested.ID);
            builder.Add(Guid.Parse("b30e75be-6d62-43ab-a1a8-5c6e718efaf0"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("971ec5b0-79d6-4dbf-988f-48227d759ec3"), Traits.Instances.Transmutation.ID);
        }

        protected override IEnumerable<WornItemVariant> GetWornItemVariants()
        {
            yield return new WornItemVariant
            {
                Id = Guid.Parse("2248c954-93b7-455b-991a-e555f5376bbe"),
                Name = "Armbands of Athleticism",
                Usage = "Worn armbands.",
                Level = 9,
                Price = 64500,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };

            yield return new WornItemVariant
            {
                Id = Guid.Parse("f32531f1-c264-440b-9c5e-a6db960a28f3"),
                Name = "Armbands of Athleticism (Greater)",
                Usage = "Worn armbands.",
                Level = 17,
                Price = 1300000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("312cc56a-3795-4afd-bb67-e797a9c4f731"), "The bonus to Athletics checks is +3, and the bonus to a successful check to Climb or Swim is +10 feet.")
                    .Build(),
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2367954a-82f0-49e8-b51e-a7f6aaec311b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 605
            };
        }
    }
}
