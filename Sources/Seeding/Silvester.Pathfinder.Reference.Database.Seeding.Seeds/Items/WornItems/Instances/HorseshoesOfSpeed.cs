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
    public class HorseshoesOfSpeed : Template
    {
        public static readonly Guid ID = Guid.Parse("fab5ed51-057c-4f93-a744-0cab855e20b6");
        
        protected override WornItem GetWornItem()
        {
            return new WornItem
            {
                Id = ID, 
                Name = "Horseshoes of Speed",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("45944044-9a4c-4747-bdab-3dda541abf76"), "When you affix these simple iron horseshoes to the hooves of an ordinary horse or a quadrupedal animal companion and the animal companion invests them, that creature gains a +5-foot item bonus to its land Speed and a +2 item bonus to Athletics checks to High Jump and Long Jump. In addition, when it Leaps, it can move 5 feet farther if jumping horizontally or 3 feet higher if jumping vertically.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("3a720bc2-bccc-4451-9c22-acb79d3671a3"), Traits.Instances.Companion.ID);
            builder.Add(Guid.Parse("c70ccefe-17b1-43b9-ae0a-22e037d8e0fd"), Traits.Instances.Invested.ID);
            builder.Add(Guid.Parse("4c6953f7-9f00-4f86-9392-c57175922d63"), Traits.Instances.Primal.ID);
            builder.Add(Guid.Parse("c0d472af-7d75-4e37-824d-a60b1d668817"), Traits.Instances.Transmutation.ID);
        }

        protected override IEnumerable<WornItemVariant> GetWornItemVariants()
        {
            yield return new WornItemVariant
            {
                Id = Guid.Parse("8c4c2138-e291-4a94-bd2b-f8d064d692b2"),
                Name = "Horseshoes of Speed",
                Usage = "Worn horseshoes.",
                Level = 7,
                Price = 34000,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };

            yield return new WornItemVariant
            {
                Id = Guid.Parse("467892a5-5093-43c5-b550-d6d4c00efba7"),
                Name = "Horseshoes of Speed (Greater)",
                Usage = "Worn horseshoes.",
                Level = 14,
                Price = 425000,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("32bae4f3-20f8-474e-ab55-178a4fe1dc8f"), "The bonus to Speed is +10 feet, and the bonus to Athletics checks is +3.")
                    .Build(),
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4e1764b9-dc7e-4675-970d-aadc81f614e7"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 604
            };
        }
    }
}
