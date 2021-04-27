using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Kitsune : AbstractTraitTemplate
    {
        public static readonly Guid ID = Guid.Parse("4f09be8d-d633-483d-b450-8c10d3cdb126");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Kitsune",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ab9a1e3f-f1d5-4652-8cf3-7b748516bb38"), Type = TextBlockType.Text, Text = "Shapeshifting humanoids whose true forms resemble foxes." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9d403011-b1d9-4470-b654-124ed91bcb3a"),
                SourceId = CoreRulebook.ID,
                Page = 141
            };
        }
    }
}
