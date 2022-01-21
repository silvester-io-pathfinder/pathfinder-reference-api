using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AdventuringGears.Instances
{
    public class WaffleIron : Template
    {
        public static readonly Guid ID = Guid.Parse("2ce66d3e-5f54-4557-b4f2-a8846fc60f16");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Waffle Iron",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("62f002fc-6503-4d80-b339-154ab7ec33a4"), "This set of hinged metal plates features studs on the inside of each plate to provide a texture for the pastry cakes you cook with it. You pour batter on the plates, close the device, and place it on a fire or stove to cook.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("0342718d-4649-4887-9103-fb57695d4bab"),
                Name = "Waffle Iron",
                Level = 0,
                Price = 50,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("bbc5f1a1-057a-4226-b1e1-d529543f303f"),
                Name = "Waffle Iron (Imprint)",
                Level = 1,
                Price = 200,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("39651f2b-5567-4541-98e1-644f5cb6fe8d"), "The plates of this waffle iron feature a noble insignia, a religious symbol, or other design to imprint onto the pastry.")
                    .Build()
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("fc6eee59-4135-40e3-a23c-1ba823c0dada"),
                Name = "Waffle Iron (Mithral)",
                Level = 8,
                Price = 35500,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("2761980e-6883-4c8f-b0cb-95256ca19699"), "The plates of this waffle iron are made of standard-grade mithral rather than iron and might bear an imprint on the plates. As with other mithral cookware, food rarely sticks to a mithral waffle iron. As it's made of mithral, this is an uncommon item.")
                    .Build()
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("1a5db23b-dcca-4ef5-9b60-945df406cf90"),
                Name = "Waffle Iron (High-Grade Mithral)",
                Level = 16,
                Price = 600500 ,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("4701f0a5-ccd0-4c60-9ef8-30851d802c06"), "Truly fit for emperors and demigods, this waffle iron is made of high-grade mithral. Although most metallurgists are certain that the much more affordable standard-grade mithral waffle iron maintains mithral's full non-stick properties, the super elite insist that only waffles made from high-grade mithral waffle irons conform to the most perfect shape and texture. Nadian has one high-grade mithral waffle iron for sale emblazoned with an archaic symbol associated with Milani from before she became a deity, supposedly used to make Milani herself waffles during her mortal life. As it's made of mithral, this is an uncommon item.")
                    .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a0a2a293-1ff6-4058-a590-58963d6fa75a"),
                SourceId = Sources.Instances.GrandBazaar.ID,
                Page = 93
            };
        }
    }
}
