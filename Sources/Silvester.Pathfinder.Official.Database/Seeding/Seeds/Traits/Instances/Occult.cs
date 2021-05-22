using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Occult : Template
    {
        public static readonly Guid ID = Guid.Parse("2e90b31a-847d-47e6-8701-bde22743f425");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Occult",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2993bb5e-03c3-4e63-90e6-7047a456e95c"), Type = TextBlockType.Text, Text = "This magic comes from the occult tradition, calling upon bizarre and ephemeral mysteries. Anything with this trait is magical." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("229e0563-7aa2-4d40-a689-d58ca5323daa"),
                SourceId = CoreRulebook.ID,
                Page = 634
            };
        }
    }
}
