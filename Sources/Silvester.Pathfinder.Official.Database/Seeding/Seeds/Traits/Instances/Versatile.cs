using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Versatile : Template
    {
        public static readonly Guid ID = Guid.Parse("9ec7b435-5128-4245-87ef-958971ac3113");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Versatile",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("065f3c01-c497-462b-b9f5-9d4cb82faf01"), Type = TextBlockType.Text, Text = "A versatile weapon can be used to deal a different type of damage than that listed in the Damage entry. This trait indicates the alternate damage type. For instance, a piercing weapon that is versatile S can be used to deal piercing or slashing damage. You choose the damage type each time you make an attack." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6c74f5a6-5526-4c9a-95bc-a5062949fd12"),
                SourceId = CoreRulebook.ID,
                Page = 283
            };
        }
    }
}
