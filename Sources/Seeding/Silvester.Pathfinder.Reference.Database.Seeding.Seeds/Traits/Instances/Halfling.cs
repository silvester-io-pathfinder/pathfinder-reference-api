using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Halfling : Template
    {
        public static readonly Guid ID = Guid.Parse("1927b1c3-5e97-426b-91e3-9618c916dfdf");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Halfling",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3e83a78a-1a44-41b7-b52e-f82c96f992d5"), Type = TextBlockType.Text, Text = "A creature with this trait is a member of the halfling ancestry. These small people are friendly wanderers considered to be lucky. An ability with this trait can be used or selected only by halflings. A weapon with this trait is created and used by halflings." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("eb7c7568-ff0c-4078-aeaa-27d53830cff6"),
                SourceId = CoreRulebook.ID,
                Page = 632
            };
        }
    }
}
