using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Misfortune : Template
    {
        public static readonly Guid ID = Guid.Parse("f44a731d-d834-4b67-875a-96d6d7daf6ee");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Misfortune",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("63c5cf53-4aa1-4ed8-a892-f282a36b3065"), Type = TextBlockType.Text, Text = "A misfortune effect detrimentally alters how you roll your dice. You can never have more than one misfortune effect alter a single roll. If multiple misfortune effects would apply, the GM decides which is worse and applies it. If a fortune effect and a misfortune effect would apply to the same roll, the two cancel each other out, and you roll normally." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6473f032-ee18-439f-a721-8c99d2d39039"),
                SourceId = CoreRulebook.ID,
                Page = 634
            };
        }
    }
}
