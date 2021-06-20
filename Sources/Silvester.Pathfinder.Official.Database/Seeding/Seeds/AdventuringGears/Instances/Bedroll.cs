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
    public class Bedroll : Template
    {
        public static readonly Guid ID = Guid.Parse("2e760e65-7138-4baf-8b51-9d7d08d02195");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Bedroll",
                Hands = "0",
                Price = 2,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("d680c63c-d31e-4133-859e-7c464cb0fce9"), Type = TextBlockType.Text, Text = "This consists of two woolen sheets sewn together along the bottom and one side to create a bag for sleeping in. Some have cloth straps along the open side so the bedroll can be tied closed while you are sleeping. It can be rolled and tied into a tight coil for storage or transport. Most people use a blanket with the bedroll to stay warm or provide a ground cushion." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c62c1853-80fb-4c06-ab1c-8ebd1fbe0930"),
                SourceId = CoreRulebook.ID,
                Page = 288
            };
        }
    }
}
