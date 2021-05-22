using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Bard : Template
    {
        public static readonly Guid ID = Guid.Parse("5c3dcdf8-1928-4f60-bd75-b7323acc0be1");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Bard",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a2b7d69b-ef65-467e-b6f1-6f33d9cc90f8"), Type = TextBlockType.Text, Text = "This indicates abilities from the bard class." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("97afe017-935d-4084-8aa0-6c905657bb09"),
                SourceId = CoreRulebook.ID,
                Page = 629
            };
        }
    }
}
