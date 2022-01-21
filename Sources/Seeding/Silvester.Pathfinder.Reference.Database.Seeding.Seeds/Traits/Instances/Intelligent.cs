using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Intelligent : Template
    {
        public static readonly Guid ID = Guid.Parse("59135a4e-ff22-4cdd-9df3-5b52a6bc6e04");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Intelligent",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("75a47869-9041-4ff5-9b6e-d1d3ac7b63e5"), Type = TextBlockType.Text, Text = "An item with this trait is intelligent and has its own will and personality, as well as several statistics that most items don't have. Intelligent items can't be crafted by normal means, and they are always rare or unique." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("30f90a3e-bd85-453c-be95-de07b8eb20f8"),
                SourceId = GamemasteryGuide.ID,
                Page = 252
            };
        }
    }
}
