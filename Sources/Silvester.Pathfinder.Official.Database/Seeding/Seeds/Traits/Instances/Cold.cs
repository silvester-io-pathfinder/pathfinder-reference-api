using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Cold : AbstractTraitTemplate
    {
        public static readonly Guid ID = Guid.Parse("6cceaf73-43d9-4249-824c-c9a03c8854bd");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Cold",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8ed32315-b62e-4817-a0cc-e6356e1ddbcd"), Type = TextBlockType.Text, Text = "Effects with this trait deal cold damage. Creatures with this trait have a connection to magical cold." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1520d805-0798-49fc-b1b3-57f8bce146e9"),
                SourceId = CoreRulebook.ID,
                Page = 629
            };
        }
    }
}
