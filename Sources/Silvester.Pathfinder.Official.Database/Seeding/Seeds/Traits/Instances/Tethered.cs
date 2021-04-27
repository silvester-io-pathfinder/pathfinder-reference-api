using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Tethered : AbstractTraitTemplate
    {
        public static readonly Guid ID = Guid.Parse("748e8459-f39f-40c6-afc3-dfb1a1ac4043");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Tethered",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b0f97ca8-fab0-44c2-abc7-f456e1047be2"), Type = TextBlockType.Text, Text = "This weapon is attached to a length of rope or chain that allows you to retrieve it after it has left your hand. If you have a free hand while wielding this weapon, you can use an Interact action to pull the weapon back into your grasp after you have thrown it as a ranged attack or after it has been disarmed (unless it is being held by another creature)." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f0b06693-a3f5-434a-a1e6-21d91deaf874"),
                SourceId = Bestiary.ID,
                Page = 85
            };
        }
    }
}
