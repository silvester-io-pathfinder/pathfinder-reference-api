using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AdventuringGears.Instances
{
    public class AlchemistsTools : Template
    {
        public static readonly Guid ID = Guid.Parse("9fbc54ea-d3f5-4fd8-8b5d-1b1cd539745e");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Alchemist's Tools",
                Hands = "2",
                Price = 300,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("bfb8773e-71f4-42ee-bd96-b8dd4ed2630a"), Type = TextBlockType.Text, Text = "This mobile collection of vials and chemicals can be used for simple alchemical tasks. If you wear your alchemist's tools, you can draw and replace them as part of the action that uses them." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e8e92ed4-2146-44db-a5d0-1c6050e51c93"),
                SourceId = CoreRulebook.ID,
                Page = 289
            };
        }
    }
}
