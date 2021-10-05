using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Grippli : Template
    {
        public static readonly Guid ID = Guid.Parse("87603781-d242-4b02-ad1c-53d2748f8878");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Grippli",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("74a80564-5070-4df8-9915-aeaf98b6a443"), Type = TextBlockType.Text, Text = "Gripplis craft and use these weapons." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("29c1755e-d7e4-4a3b-bb3e-83a9faed35f1"),
                SourceId = Pathfinder146.ID,
                Page = 86
            };
        }
    }
}
