using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Vocal : Template
    {
        public static readonly Guid ID = Guid.Parse("50665b47-21f0-4bc7-93c6-df8227a5dcff");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Vocal",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f1abc3ca-eefb-45bd-bce0-f270803a1738"), Type = TextBlockType.Text, Text = "There was not explicit description for this trait." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c02ba361-d6c7-4c68-a623-7642b66bec9f"),
                SourceId = Pathfinder153.ID,
                Page = 76
            };
        }
    }
}
