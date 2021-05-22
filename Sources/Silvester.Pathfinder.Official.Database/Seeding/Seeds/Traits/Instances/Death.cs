using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Death : Template
    {
        public static readonly Guid ID = Guid.Parse("2d273e11-bba7-4024-8d54-5449e202428b");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Death",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4899ceae-ca0f-440c-b224-b3b39c7a9f54"), Type = TextBlockType.Text, Text = "An effect with the death trait kills you immediately if it reduces you to 0 HP. Some death effects can bring you closer to death or slay you outright without reducing you to 0 HP." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2e091a59-aeff-476a-9877-a1d08bfb0536"),
                SourceId = CoreRulebook.ID,
                Page = 630
            };
        }
    }
}
