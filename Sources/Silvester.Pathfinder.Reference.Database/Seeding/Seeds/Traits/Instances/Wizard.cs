using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Wizard : Template
    {
        public static readonly Guid ID = Guid.Parse("b02b7942-423b-4b11-83b1-15a30643e7dc");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Wizard",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b6b0ed87-86ef-48ae-9596-4db024536bbc"), Type = TextBlockType.Text, Text = "This indicates abilities from the wizard class." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ca9d4545-6038-4909-b7e2-271fea1d2e6b"),
                SourceId = CoreRulebook.ID,
                Page = 638
            };
        }
    }
}
