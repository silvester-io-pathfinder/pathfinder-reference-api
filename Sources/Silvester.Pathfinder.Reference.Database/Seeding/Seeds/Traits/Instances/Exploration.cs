using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Exploration : Template
    {
        public static readonly Guid ID = Guid.Parse("51d79f88-951a-49bc-b45d-ddf2a8a1c793");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Exploration",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("69ead9e1-720b-4c26-9e4d-624a6f868be6"), Type = TextBlockType.Text, Text = "An activity with this trait takes more than a turn to use, and can usually be used only during exploration mode." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("309be26b-4642-48d8-8d69-bb2a06a88bcb"),
                SourceId = CoreRulebook.ID,
                Page = 631
            };
        }
    }
}
