using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Dedication : AbstractTraitTemplate
    {
        public static readonly Guid ID = Guid.Parse("6a759553-36b4-4d02-86ff-3348970fc639");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Dedication",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("edde93d8-4fda-4de0-a7db-63363cc73a69"), Type = TextBlockType.Text, Text = "You must select a feat with this trait to apply an archetype to your character." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9a5f1f77-a7e4-448b-a917-fef2e2af308f"),
                SourceId = CoreRulebook.ID,
                Page = 630
            };
        }
    }
}
