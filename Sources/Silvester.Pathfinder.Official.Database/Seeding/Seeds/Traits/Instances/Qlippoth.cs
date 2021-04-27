using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Qlippoth : AbstractTraitTemplate
    {
        public static readonly Guid ID = Guid.Parse("eb5f3f8a-00c4-4836-9345-cac3a59f5980");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Qlippoth",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7ac5518e-664b-4c98-95a3-2625d3ca4dc9"), Type = TextBlockType.Text, Text = "A family of fiends hailing from the Abyss, most qlippoth are chaotic evil. Their appearance affects the minds of non-qlippoth that view them." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("96a79e45-3b76-4734-b296-63820b531abe"),
                SourceId = Bestiary2.ID,
                Page = 309
            };
        }
    }
}
