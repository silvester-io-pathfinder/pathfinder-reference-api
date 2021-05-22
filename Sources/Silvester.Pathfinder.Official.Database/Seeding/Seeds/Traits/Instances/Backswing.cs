using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Backswing : Template
    {
        public static readonly Guid ID = Guid.Parse("2f14e52a-05b8-4abc-a720-d2e9d943538f");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Backswing",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("08057b12-30c0-4d14-b5fc-441fd1671655"), Type = TextBlockType.Text, Text = "You can use the momentum from a missed attack with this weapon to lead into your next attack. After missing with this weapon on your turn, you gain a +1 circumstance bonus to your next attack with this weapon before the end of your turn." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("41a5d833-2994-43db-be23-bc430b824f2b"),
                SourceId = CoreRulebook.ID,
                Page = 282
            };
        }
    }
}
