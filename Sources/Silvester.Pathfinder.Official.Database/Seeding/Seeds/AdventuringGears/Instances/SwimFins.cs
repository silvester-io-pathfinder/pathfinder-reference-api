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
    public class SwimFins : Template
    {
        public static readonly Guid ID = Guid.Parse("0dc8ba27-c35d-430b-ac20-5ae0e659ca86");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Swim Fins",
                Hands = "0",
                ItemLevel = "0",
                Price = 500,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("4482f6cb-0808-4a4a-b543-a15fe80c1ccf"), Type = TextBlockType.Text, Text = "These flippers attach to your feet like tight shoes—donning or removing them requires three Interact actions. While worn, you gain a +5-foot item bonus to the distance you move when rolling Athletics to Swim, not when using a swim Speed, and you take a –10-foot item penalty to your Speed." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("451042d0-831d-4f24-b3a9-85bbb522f7bb"),
                SourceId = WorldGuide.ID,
                Page = 69
            };
        }
    }
}
