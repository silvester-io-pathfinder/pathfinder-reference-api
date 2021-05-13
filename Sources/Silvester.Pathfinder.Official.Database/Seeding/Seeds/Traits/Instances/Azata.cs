using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Azata : Template
    {
        public static readonly Guid ID = Guid.Parse("f35d2381-a82a-4ad6-8ac8-19fd84a42dda");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Azata",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e7b69acf-969e-4dbd-a5c3-b405bdb9a2c7"), Type = TextBlockType.Text, Text = "This family of celestials is native to Elysium. They are typically chaotic good and have darkvision and a weakness to evil and cold iron." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d3a050e1-e54e-4eb8-b95f-d9180afb889e"),
                SourceId = CoreRulebook.ID,
                Page = 629
            };
        }
    }
}
