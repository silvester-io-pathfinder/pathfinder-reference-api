using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Suli : Template
    {
        public static readonly Guid ID = Guid.Parse("3a2a06a6-88ec-4cdc-8577-9beaaa4c5407");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Suli",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4e375f84-2d3c-4411-8a89-283193f2e96c"), Type = TextBlockType.Text, Text = "Sulis are planar scions descended from jann." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3dd646a9-a8be-4c1e-bc91-8244171e8f34"),
                SourceId = Bestiary2.ID,
                Page = 610
            };
        }
    }
}
