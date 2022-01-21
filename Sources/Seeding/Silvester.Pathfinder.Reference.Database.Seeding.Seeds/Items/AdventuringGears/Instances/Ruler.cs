using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AdventuringGears.Instances
{
    public class Ruler : Template
    {
        public static readonly Guid ID = Guid.Parse("be4541a0-3103-4718-b398-cd2a4dfc9295");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Ruler",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("36a20efa-fdb6-4611-a536-4dd539b2bd3f"), "A ruler is a straight-edged object used for measuring small distances accurately and drawing straight lines.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("10efa614-7829-4665-8dea-3c74feaf6106"),
                Name = "Ruler",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 0,
                Price = 50,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a30ac35f-e8b5-4d90-ae44-baa07af61855"),
                SourceId = Sources.Instances.PathfinderSocietyGuide.ID,
                Page = 34
            };
        }
    }
}
