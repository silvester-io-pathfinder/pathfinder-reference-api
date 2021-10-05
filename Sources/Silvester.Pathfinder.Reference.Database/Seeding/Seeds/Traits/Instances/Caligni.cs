using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Caligni : Template
    {
        public static readonly Guid ID = Guid.Parse("d7ffb83a-2507-4d2c-ba39-9faa6c59565e");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Caligni",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("944852cc-7080-4f50-a416-d5211e2eb26f"), Type = TextBlockType.Text, Text = "These subterranean people have darkvision, and some have powers to create darkness." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("67338fc5-ebe1-4f97-b5a8-2e26b4e8feb3"),
                SourceId = Bestiary.ID,
                Page = 345
            };
        }
    }
}
