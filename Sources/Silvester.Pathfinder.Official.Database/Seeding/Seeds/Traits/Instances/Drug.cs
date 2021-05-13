using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Drug : Template
    {
        public static readonly Guid ID = Guid.Parse("a47987be-2821-409e-a9f9-cf1a231772f6");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Drug",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4bb7fadc-67e6-4f00-b6de-4e297c7e08a1"), Type = TextBlockType.Text, Text = "An item with this trait is a drug, a poison that conveys short-term benefits in addition to harmful side effects and long-term consequences. Each time a creature uses a given drug it must also attempt a saving throw against addiction to that drug." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e7081884-b7db-4b1e-9ffc-721d2ca820b6"),
                SourceId = GamemasteryGuide.ID,
                Page = 251
            };
        }
    }
}
