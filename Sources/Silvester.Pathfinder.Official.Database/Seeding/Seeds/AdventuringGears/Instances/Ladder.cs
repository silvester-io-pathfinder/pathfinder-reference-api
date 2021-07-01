using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AdventuringGears.Instances
{
    public class Ladder : Template
    {
        public static readonly Guid ID = Guid.Parse("7769a9fc-e764-47c3-a34a-1eba746e293a");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Ladder",
                Hands = "2",
                Price = 3,
                BulkId = Bulks.Instances.ThreeBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("bd148448-e5fd-4cf8-aeba-6f6914b94f1e"), Type = TextBlockType.Text, Text = "A piece of equipment consisting of a series of bars or steps between two upright lengths of wood, metal, or rope, used for climbing up or down something." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("244f6a18-cc4c-46cb-ba34-6c63cca7b02f"),
                SourceId = CoreRulebook.ID,
                Page = 288
            };
        }
    }
}
