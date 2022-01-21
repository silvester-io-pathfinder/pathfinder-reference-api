using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AdventuringGears.Instances
{
    public class Clay : Template
    {
        public static readonly Guid ID = Guid.Parse("cbbe744b-59a7-4927-8795-c92b8b93ca97");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Clay",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("64c3e0e2-61fa-46f1-898f-94ec153aa2d0"), "This malleable, oil-based clay can be shaped by hand and is available in a variety of colors. A single unit has 4 ounces of clay.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("ceab787f-63cc-436b-a34f-c85134640742"),
                Name = "Clay",
                Usage = "Held in 2 hands.",
                Hands = "2",
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
                Id = Guid.Parse("2fb60879-0300-403c-8770-8d6e4e4f957f"),
                SourceId = Sources.Instances.GrandBazaar.ID,
                Page = 58
            };
        }
    }
}
