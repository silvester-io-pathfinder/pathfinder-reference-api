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
    public class Waterskin : Template
    {
        public static readonly Guid ID = Guid.Parse("7787539a-8ec2-461f-9c9a-92b7f8e090b2");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Waterskin",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("6bb4e722-12ee-4eb4-a867-b9f1861876db"), "When it's full, a waterskin contains roughly 1 day's worth of water for a Small or Medium creature.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("68b0f6dd-8009-4753-84f1-8fc743d8bb34"),
                Name = "Waterskin",
                Hands = "1",
                Price = 5,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6483fd5b-441a-4aba-8177-6f7dc051a114"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 292
            };
        }
    }
}
