using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Cleric : Template
    {
        public static readonly Guid ID = Guid.Parse("6e219362-f25e-4f21-b9b1-494f24e689c1");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Cleric",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("cacc98f1-7f03-4698-bd43-54a37a3eee7a"), Type = TextBlockType.Text, Text = "This indicates abilities from the cleric class." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a060a8a5-7ebf-4062-b953-c7ae64793cee"),
                SourceId = CoreRulebook.ID,
                Page = 629
            };
        }
    }
}
