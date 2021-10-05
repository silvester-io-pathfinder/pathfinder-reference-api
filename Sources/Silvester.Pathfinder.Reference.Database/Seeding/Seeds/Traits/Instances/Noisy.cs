using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Noisy : Template
    {
        public static readonly Guid ID = Guid.Parse("dea9ff31-9ed5-44e2-917d-f4b269e6a974");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Noisy",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4c020c2c-6e31-4f56-8527-e9a681c8ac49"), Type = TextBlockType.Text, Text = "This armor is loud and likely to alert others to your presence. The armor’s check penalty applies to Stealth checks even if you meet the required Strength score." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7161709a-8516-45ab-bd36-43aedcc7cbb7"),
                SourceId = CoreRulebook.ID,
                Page = 275
            };
        }
    }
}
