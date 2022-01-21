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
    public class Chalk : Template
    {
        public static readonly Guid ID = Guid.Parse("aafa026c-7a02-4479-a20a-ddae6fbcd0b8");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Chalk",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("436c7e69-5810-4a56-902b-d7d7f9b47f2a"), "Chalk is a soft, white, porous, sedimentary carbonate rock, a form of limestone composed of the mineral calcite and originally formed deep under the sea by the compression of sub-microscopic plankton which had fallen to the sea floor.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("b4a30a03-c1c2-4a48-aac6-e4b38db5f4d2"),
                Name = "Chalk",
                Hands = "1",
                Level = 0,
                Price = 1,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("855558ff-8646-4f0c-bf2d-07ff7e6c901e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 288
            };
        }
    }
}
