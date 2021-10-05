using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Linguistic : Template
    {
        public static readonly Guid ID = Guid.Parse("e6f83e03-dfaa-46dc-ae44-dc013bf6649d");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Linguistic",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0ba59c3b-efa2-4089-8125-2d6dccf96f2a"), Type = TextBlockType.Text, Text = "An effect with this trait depends on language comprehension. A linguistic effect that targets a creature works only if the target understands the language you are using." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("938844ab-85ab-42fa-812b-4c9fe2f99aee"),
                SourceId = CoreRulebook.ID,
                Page = 633
            };
        }
    }
}
