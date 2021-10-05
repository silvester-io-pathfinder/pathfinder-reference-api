using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Dwarf : Template
    {
        public static readonly Guid ID = Guid.Parse("3ecd4d1e-ccc1-4620-b223-63aa9031fe5a");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Dwarf",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3c157271-ce4d-42d3-8426-5dce0cae1f36"), Type = TextBlockType.Text, Text = "Dwarf" };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7622bab4-7f37-43b3-a3e1-c9d1c63dabd9"),
                SourceId = CoreRulebook.ID,
                Page = 631
            };
        }
    }
}
