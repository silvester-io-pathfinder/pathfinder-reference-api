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
    public class SignalWhistle : Template
    {
        public static readonly Guid ID = Guid.Parse("6f279ee2-bc01-424a-b17e-458c8d58b303");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Signal Whistle",
                Hands = "1",
                ItemLevel = "0",
                Price = 8,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("364a65b0-7803-4df4-8b77-6850ddbae75f"), Type = TextBlockType.Text, Text = "When sounded, a signal whistle can be heard clearly up to half a mile away across open terrain." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6cf40523-4844-4ba5-a8d1-e7677c26a64c"),
                SourceId = CoreRulebook.ID,
                Page = 291
            };
        }
    }
}
