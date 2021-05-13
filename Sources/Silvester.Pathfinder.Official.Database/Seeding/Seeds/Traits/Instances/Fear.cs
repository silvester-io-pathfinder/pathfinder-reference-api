using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Fear : Template
    {
        public static readonly Guid ID = Guid.Parse("74e59198-7926-491e-a7f6-62e21d4b8e69");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Fear",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9e31265b-65dc-4139-abaa-ab1c718c7c41"), Type = TextBlockType.Text, Text = "Fear effects evoke the emotion of fear. Effects with this trait always have the mental and emotion traits as well." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0bdee1c1-e5c5-49f8-88d7-afc254478de5"),
                SourceId = CoreRulebook.ID,
                Page = 631
            };
        }
    }
}
