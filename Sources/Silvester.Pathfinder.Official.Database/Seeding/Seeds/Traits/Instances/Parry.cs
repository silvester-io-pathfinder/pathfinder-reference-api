using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Parry : Template
    {
        public static readonly Guid ID = Guid.Parse("bb4ffbbe-5eb1-485a-85c0-60189414e3d4");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Parry",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a253edf2-2a70-4ae7-9afa-fef547918d2b"), Type = TextBlockType.Text, Text = "This weapon can be used defensively to block attacks. While wielding this weapon, if your proficiency with it is trained or better, you can spend a single action to position your weapon defensively, gaining a +1 circumstance bonus to AC until the start of your next turn." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4acf222a-c679-4d4d-9a3d-4f50adbfae99"),
                SourceId = CoreRulebook.ID,
                Page = 283
            };
        }
    }
}
