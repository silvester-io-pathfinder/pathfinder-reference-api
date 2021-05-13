using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class RangedTrip : Template
    {
        public static readonly Guid ID = Guid.Parse("dcd0b784-a7c5-43dd-ae92-a5c4b94041d5");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Ranged Trip",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("185949b5-134d-43dd-9ee3-0887273b571f"), Type = TextBlockType.Text, Text = "This weapon can be used to Trip with the Athletics skill at a distance up to the weapon's first range increment. The skill check takes a –2 circumstance penalty. You can add the weapon's item bonus to attack rolls as a bonus to the check. As with using a melee weapon to trip, a ranged trip doesn't deal any damage when used to Trip. This trait usually appears only on a thrown weapon." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("450eae14-6472-4299-bb65-ae790fe20079"),
                SourceId = AdvancedPlayersGuide.ID,
                Page = 269
            };
        }
    }
}
