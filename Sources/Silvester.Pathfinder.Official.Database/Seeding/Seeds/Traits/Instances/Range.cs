using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Range : Template
    {
        public static readonly Guid ID = Guid.Parse("5933ad4b-93c3-4422-b954-2ec796dda2b0");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Range",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f3ac0658-44fe-4b90-bda8-16db8faa9104"), Type = TextBlockType.Text, Text = "These attacks will either list a finite range or a range increment, which follows the normal rules for range increments." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2cfa28ac-1c80-46ac-8217-2e272cb7a0fd"),
                SourceId = Bestiary.ID,
                Page = 17
            };
        }
    }
}
