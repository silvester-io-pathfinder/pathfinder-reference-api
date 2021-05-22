using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Timeless : Template
    {
        public static readonly Guid ID = Guid.Parse("0a3a3730-eb95-4601-ac6e-c76caca8909d");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Timeless",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d41d0e65-6091-440a-a624-6a8f81ac1533"), Type = TextBlockType.Text, Text = "On planes with this trait, time still passes but its effects are diminished." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4ce18d6f-34ee-46cd-88e9-eef5b5598034"),
                SourceId = GamemasteryGuide.ID,
                Page = 254
            };
        }
    }
}
