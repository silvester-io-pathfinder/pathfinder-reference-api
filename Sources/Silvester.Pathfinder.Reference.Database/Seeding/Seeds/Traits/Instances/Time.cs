using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Time : Template
    {
        public static readonly Guid ID = Guid.Parse("b90498d1-69ae-4c10-8e98-94857099bbda");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Time",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("40fecba2-63ce-49df-b25d-d6028805fa9b"), Type = TextBlockType.Text, Text = "Time creatures are natives of the Dimension of Time. They do not age, and while some may be driven by supernatural hungers, they do not need to eat or drink to survive. They can survive the basic environmental effects of the Dimension of Time." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("53139da1-e98c-46f8-8525-c3a1e3478fa3"),
                SourceId = Bestiary2.ID,
                Page = 310
            };
        }
    }
}
