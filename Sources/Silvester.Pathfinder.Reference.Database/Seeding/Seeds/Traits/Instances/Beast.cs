using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Beast : Template
    {
        public static readonly Guid ID = Guid.Parse("24b77a08-9548-4a40-b4e3-186e21b6a55b");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Beast",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b7840c74-14a4-49be-89a2-2ebfe9cc898f"), Type = TextBlockType.Text, Text = "A creature similar to an animal but with an Intelligence modifier of –3 or higher is usually a beast. Unlike an animal, a beast might be able to speak and reason." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9fa0feb9-5e27-47b3-85ea-cdb18ff1f43f"),
                SourceId = CoreRulebook.ID,
                Page = 629
            };
        }
    }
}
