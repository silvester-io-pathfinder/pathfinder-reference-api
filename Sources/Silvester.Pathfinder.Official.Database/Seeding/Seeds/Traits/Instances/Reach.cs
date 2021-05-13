using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Reach : Template
    {
        public static readonly Guid ID = Guid.Parse("e864e521-13c1-4192-a530-9c461132766f");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Reach",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a602db3d-2e37-454d-9bd3-4ff88ef20a0e"), Type = TextBlockType.Text, Text = "Natural attacks with this trait can be used to attack creatures up to the listed distance away instead of only adjacent creatures. Weapons with this trait are long and can be used to attack creatures up to 10 feet away instead of only adjacent creatures. For creatures that already have reach with the limb or limbs that wield the weapon, the weapon increases their reach by 5 feet." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("528810f2-be89-43f0-9eca-49d834b685fe"),
                SourceId = CoreRulebook.ID,
                Page = 283
            };
        }
    }
}
