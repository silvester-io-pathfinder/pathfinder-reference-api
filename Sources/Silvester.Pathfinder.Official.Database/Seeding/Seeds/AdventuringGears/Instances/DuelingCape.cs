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
    public class DuelingCape : Template
    {
        public static readonly Guid ID = Guid.Parse("e2e6da71-2f98-46c2-80eb-adb3ba10fcaa");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Dueling Cape",
                Hands = "1",
                Price = 50,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("767ec192-efd1-4f95-b869-5754be5142b4"), Type = TextBlockType.Text, Text = "You can pull a dueling cape you're wearing from your shoulder and wrap it around your arm with an Interact action. While wielding the dueling cape this way, the cape uses that arm and hand, and you can't hold anything else in that hand. While you do so, you can spend an action to hold it in a protective position, giving you a +1 circumstance bonus to AC and to Deception checks to Feint until the start of your next turn." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e8459024-60cd-46ec-b64d-7b1b1adb308f"),
                SourceId = AdvancedPlayersGuide.ID,
                Page = 249
            };
        }
    }
}
