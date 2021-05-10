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
    public class Piton : AbstractAdventuringGearTemplate
    {
        public static readonly Guid ID = Guid.Parse("1a6ef531-3bb2-45ea-8946-b6234ff93796");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Piton",
                Hands = "1",
                ItemLevel = "0",
                Price = 1,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("f5aac716-bbf7-4b8d-b00c-98c0fc2ad901"), Type = TextBlockType.Text, Text = "These small spikes can be used as anchors to make climbing easier. To affix a piton, you must hold it in one hand and use a hammer to drive it in with your other hand. You can attach a rope to the hammered piton so that you don't fall all the way to the ground on a critical failure while Climbing." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c0269601-b805-4072-bf5e-47dccbc21d78"),
                SourceId = CoreRulebook.ID,
                Page = 291
            };
        }
    }
}
