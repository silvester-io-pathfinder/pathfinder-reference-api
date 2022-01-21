using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AdventuringGears.Instances
{
    public class Pinwheel : Template
    {
        public static readonly Guid ID = Guid.Parse("9270ff85-9f5d-425b-9bea-95b256eb4845");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Pinwheel",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("b3ebe60d-16a3-477e-999b-1087c593c87f"), "This paper and wood pinwheel spins when blown upon by a person or the wind.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("bbc54523-1306-40d2-8492-29052299af3c"),
                Name = "Pinwheel",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 0,
                Price = 1,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2fc805bb-6e7d-47dc-b656-25bb4e1ad550"),
                SourceId = Sources.Instances.GrandBazaar.ID,
                Page = 59
            };
        }
    }
}
