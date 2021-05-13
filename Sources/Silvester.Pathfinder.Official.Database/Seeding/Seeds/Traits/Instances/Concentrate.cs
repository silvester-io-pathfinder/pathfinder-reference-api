using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Concentrate : Template
    {
        public static readonly Guid ID = Guid.Parse("108f08d2-0bd2-48af-94f5-a39b439814d1");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Concentrate",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1fcf61fc-f517-4688-b632-da31a81af60b"), Type = TextBlockType.Text, Text = "An action with this trait requires a degree of mental concentration and discipline." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9e48ea6d-3cb7-4318-b034-5e5fc2da15f6"),
                SourceId = CoreRulebook.ID,
                Page = 629
            };
        }
    }
}
