using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Potion : AbstractTraitTemplate
    {
        public static readonly Guid ID = Guid.Parse("88776d22-b742-42ed-80a2-80dcb0379070");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Potion",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2fb08814-3a1c-48cd-8564-1d2f8b3eef4e"), Type = TextBlockType.Text, Text = "A potion is a magical liquid activated when you drink it." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2a5eae84-c84f-4695-850a-b42a63ea2265"),
                SourceId = CoreRulebook.ID,
                Page = 635
            };
        }
    }
}
