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
    public class Comealong : Template
    {
        public static readonly Guid ID = Guid.Parse("085cf660-739c-422e-a019-9d821a31e394");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Comealong",
                Hands = "2",
                ItemLevel = "0",
                Price = 300,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("f7b95429-bc12-4034-811d-809d37c4a8b9"), Type = TextBlockType.Text, Text = "This portable winch consists of a length of cable or chain, two hooks, and a ratcheting drum with a handle. When used with two sections of rope or chain, it allows you to pull a heavy load along a flat surface." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6ef31e22-1091-4e65-8fd8-95b8a892b6f0"),
                SourceId = PathfinderSocietyGuide.ID,
                Page = 114
            };
        }
    }
}
