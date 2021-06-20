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
    public class Torch : Template
    {
        public static readonly Guid ID = Guid.Parse("e71752ce-5078-41c3-a4bd-8313073efd3d");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Torch",
                Hands = "1",
                Price = 1,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("b4b6d8b8-e2aa-41d4-a74a-e8b6c910b5fc"), Type = TextBlockType.Text, Text = "A torch sheds bright light in a 20-foot radius (and dim light to the next 20 feet) for 1 hour. It can be used as an improvised weapon that deals 1d4 bludgeoning damage plus 1 fire damage." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("88e2daa7-f121-495c-9159-084ce47aacb9"),
                SourceId = CoreRulebook.ID,
                Page = 292
            };
        }
    }
}
