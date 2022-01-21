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
    public class BootsOfBounding : Template
    {
        public static readonly Guid ID = Guid.Parse("da0bb266-c5a1-4ab3-b6e9-10937e73103c");
        
        protected override WornItem GetWornItem()
        {
            return new WornItem
            {
                Id = ID, 
                Name = "Boots of Bounding",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("a5065956-d492-4fa6-9f59-c14fd5ed594c"), "The springy soles of these sturdy leather boots cushion your feet and make each step lighter. These boots give you a +5-foot item bonus to your Speed and a +2 item bonus to Athletics checks to High Jump and Long Jump. In addition, when you use the Leap action, you can move 5 feet further if jumping horizontally or 3 feet higher if jumping vertically.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("fcf7cb74-805f-4a3d-a8e2-e0c8f8d329ca"), Traits.Instances.Invested.ID);
            builder.Add(Guid.Parse("2c0974d1-b262-4db0-b63b-5ccdf8130c9a"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("dea34417-35c4-4f4c-bf8f-98496fc4781a"), Traits.Instances.Transmutation.ID);
        }

        protected override IEnumerable<WornItemVariant> GetWornItemVariants()
        {
            yield return new WornItemVariant
            {
                Id = Guid.Parse("1ac185cf-f443-4cc9-9d04-8f299277bcda"),
                Name = "Boots of Bounding",
                CraftingRequirements = "",
                Usage = "Worn shoes.",
                Level = 7,
                Price = 34000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };

            yield return new WornItemVariant
            {
                Id = Guid.Parse("9579eb96-f57d-4394-b885-c67f8eefaa4e"),
                Name = "Boots of Bounding (Greater)",
                CraftingRequirements = "",
                Usage = "Worn shoes.",
                Level = 14,
                Price = 425000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("60acec1e-d3f3-4049-927e-16653280fe76"), "The bonus to Speed is +10 feet, and the bonus to High Jump and Long Jump is +3.")
                    .Build(),
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cc14c92e-b751-4481-9d16-38a493624a90"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 606
            };
        }
    }
}
