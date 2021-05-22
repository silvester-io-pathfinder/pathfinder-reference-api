using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Common : Template
    {
        public static readonly Guid ID = Guid.Parse("6ab071b5-1126-460e-ac21-4eb6fecfad1e");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Common",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("79a0fbf2-e358-4816-aa35-019510ccb150"), Type = TextBlockType.Text, Text = "Anything that doesn't list another rarity trait (uncommon, rare, or unique) automatically has the common trait. This rarity indicates that an ability, item, or spell is available to all players who meet the prerequisites for it. A creature of this rarity is generally known and can be summoned with the appropriate summon spell." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a3963a5d-3cfc-40e8-bb67-2bb81e7dd988"),
                SourceId = CoreRulebook.ID,
                Page = 629
            };
        }
    }
}
