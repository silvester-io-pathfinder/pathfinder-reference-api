using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Merfolk : Template
    {
        public static readonly Guid ID = Guid.Parse("ffd4a22a-42a6-40e5-92ad-f5f9f1fdbfdb");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Merfolk",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5a02f889-e842-4fee-aaab-405a45006761"), Type = TextBlockType.Text, Text = "These aquatic humanoids have an upper body similar to a human and a lower body similar to a fish." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("78056fbf-e753-44b3-8eeb-d011d4ee647b"),
                SourceId = Bestiary.ID,
                Page = 347
            };
        }
    }
}
