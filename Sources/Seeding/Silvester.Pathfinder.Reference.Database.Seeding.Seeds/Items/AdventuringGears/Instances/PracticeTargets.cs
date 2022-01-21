using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AdventuringGears.Instances
{
    public class PracticeTargets : Template
    {
        public static readonly Guid ID = Guid.Parse("5b09eb09-71fc-481c-96fe-ebe37bf2bf79");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Practice Targets",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("25b3a5ef-26ad-4f0b-ba21-57e5d18763fe"), "While gunslingers have many methods for practicing their aim, these sturdy paper targets are excellent for tracking a gunslinger's progress over time, keeping score of how close they came to hitting the most vital spots. These targets are also used in situations where more detailed accuracy must be recorded, such as firearm competitions. Practice targets can appear in many shapes and sizes and usually come in packs of 10 held in protective cases made of heavy cloth or light leather.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("42fba415-8dfd-4f50-96aa-054900fec6c1"),
                Name = "Practice Targets",
                Level = 0,
                Price = 20,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f214d42f-cf5f-46bd-82ba-0dec7eea4f18"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 179
            };
        }
    }
}
