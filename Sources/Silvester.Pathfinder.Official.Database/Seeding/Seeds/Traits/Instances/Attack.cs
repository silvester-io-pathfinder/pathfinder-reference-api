using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Attack : AbstractTraitTemplate
    {
        public static readonly Guid ID = Guid.Parse("00aef935-be7a-4bfe-8aea-6c281f9dc756");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Attack",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2d59cb58-7d34-40b4-9d2e-9088c5bbf3cd"), Type = TextBlockType.Text, Text = "An ability with this trait involves an attack. For each attack you make beyond the first on your turn, you take a multiple attack penalty. Actions" };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8e9dd99e-0cd5-427c-8965-737a6ed2418e"),
                SourceId = CoreRulebook.ID,
                Page = 629
            };
        }
    }
}
