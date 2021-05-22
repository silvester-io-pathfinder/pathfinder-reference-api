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
    public class TenFootPole : Template
    {
        public static readonly Guid ID = Guid.Parse("8969e927-035e-4927-a554-96ced3b112d0");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Ten-Foot Pole",
                Hands = "2",
                ItemLevel = "0",
                Price = 1,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("4276b9ed-b141-4625-b3db-acdb095eb4b5"), Type = TextBlockType.Text, Text = "When wielding this long pole, you can use Seek to search a square up to 10 feet away. The pole is not sturdy enough to use as a weapon." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7ba180cd-c1cf-44e4-b432-21d24f909d18"),
                SourceId = CoreRulebook.ID,
                Page = 291
            };
        }
    }
}
