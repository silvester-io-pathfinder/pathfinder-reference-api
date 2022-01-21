using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AdventuringGears.Instances
{
    public class Electrocable : Template
    {
        public static readonly Guid ID = Guid.Parse("04ad496f-d525-424b-bb6e-ea43b0857aed");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear
            {
                Id = ID,
                Name = "Electrocable",
            };
        }
        
        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("a1391d0b-2767-4d67-aa04-89f9e46a47c1"), "This footlong length of conductive cable is capped on both ends by grounded handles containing Stasian coils. These coils can be turned on or off as a single action. While on, the coils electrify the cable, dealing 1d6 electricity and 1d6 fire damage in a thin precise line to anything the cable touches, though the cable is too unwieldy to use as a weapon. Electrocables are typically used to �cut� a thin straight line through metal. They ignore 10 points of a metal object�s hardness.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("26c07fcf-f5ee-4aab-af28-69f78561f307"), Traits.Instances.Rare.ID);
            builder.Add(Guid.Parse("e9789e70-31f0-47ec-be7c-01edf4f02d71"), Traits.Instances.Electricity.ID);
            builder.Add(Guid.Parse("9d861597-4134-4aa2-848e-45ad50175000"), Traits.Instances.Fire.ID);
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("ea802f97-70e1-4477-9d0e-9461ff9a0701"),
                Name = "Electrocable",
                Usage = "Held in 2 hands.",
                Level = 3,
                Price = 4500,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Rare.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c68637fd-c169-4bae-ae9f-d9a532a39522"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 87
            };
        }
    }
}
