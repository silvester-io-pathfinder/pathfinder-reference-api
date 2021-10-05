using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Druid : Template
    {
        public static readonly Guid ID = Guid.Parse("8edb189f-b26e-47d2-92df-08dbec04781a");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Druid",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8d81f589-7840-49a0-97d3-7e209b1cd785"), Type = TextBlockType.Text, Text = "This indicates abilities from the druid class." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("63d3036e-5db1-46f9-b54b-01d7060fc829"),
                SourceId = CoreRulebook.ID,
                Page = 631
            };
        }
    }
}
