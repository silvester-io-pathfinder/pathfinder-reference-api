using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Fiend : Template
    {
        public static readonly Guid ID = Guid.Parse("166f8aea-94f8-42a9-b506-215ffb4a72a1");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Fiend",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a1d8efc1-0d73-4f00-9c77-b16c8c20ab2f"), Type = TextBlockType.Text, Text = "Creatures that hail from or have a strong connection to the evil-aligned planes are called fiends. Fiends can survive the basic environmental effects of planes in the Outer Sphere." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6f1d145c-3a94-4f81-8dff-81d6d83486c9"),
                SourceId = CoreRulebook.ID,
                Page = 631
            };
        }
    }
}
