using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AdventuringGears.Instances
{
    public class Chalk : AbstractAdventuringGearTemplate
    {
        public static readonly Guid ID = Guid.Parse("aafa026c-7a02-4479-a20a-ddae6fbcd0b8");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Chalk",
                Hands = "1",
                ItemLevel = "0",
                Price = 1,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("436c7e69-5810-4a56-902b-d7d7f9b47f2a"), Type = TextBlockType.Text, Text = "Chalk is a soft, white, porous, sedimentary carbonate rock, a form of limestone composed of the mineral calcite and originally formed deep under the sea by the compression of sub-microscopic plankton which had fallen to the sea floor." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("855558ff-8646-4f0c-bf2d-07ff7e6c901e"),
                SourceId = CoreRulebook.ID,
                Page = 288
            };
        }
    }
}
