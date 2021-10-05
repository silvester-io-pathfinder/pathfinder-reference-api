using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Elf : Template
    {
        public static readonly Guid ID = Guid.Parse("1efe88ff-776a-4fef-bcda-1ba9b63154e1");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Elf",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d75acf18-0f8b-49bc-a9ce-7b03c1621095"), Type = TextBlockType.Text, Text = "A creature with this trait is a member of the elf ancestry. Elves are mysterious people with rich traditions of magic and scholarship who typically have low-light vision. An ability with this trait can be used or selected only by elves. A weapon with this trait is created and used by elves." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("60d50565-c84e-4346-ba3a-ca9f500ae8f2"),
                SourceId = CoreRulebook.ID,
                Page = 631
            };
        }
    }
}
