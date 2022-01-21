using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Seugathi : Template
    {
        public static readonly Guid ID = Guid.Parse("28df6172-2367-4910-950e-d88f0c9d0864");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Seugathi",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6835532a-9460-436b-9b22-e92a43a0ef6a"), Type = TextBlockType.Text, Text = "There was not explicit description for this trait." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8b929565-f899-41a2-9849-95beb5a5aef4"),
                SourceId = Pathfinder164.ID,
                Page = 82
            };
        }
    }
}
