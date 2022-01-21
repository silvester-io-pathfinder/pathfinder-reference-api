using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Litany : Template
    {
        public static readonly Guid ID = Guid.Parse("c6a2e39a-db66-42d3-8973-21a214fdca57");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Litany",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7424e2f0-8f5a-4122-9aa9-fb90343d57a7"), Type = TextBlockType.Text, Text = "Litanies are special devotion spells, typically used by champions and requiring a single action, that usually give temporary immunity to further litanies." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1593fdd2-f778-47a1-953f-c275211811f3"),
                SourceId = CoreRulebook.ID,
                Page = 633
            };
        }
    }
}
