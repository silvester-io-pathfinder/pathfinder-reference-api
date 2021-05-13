using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Mechanical : Template
    {
        public static readonly Guid ID = Guid.Parse("560c2c5c-245a-4d72-aad3-964dfc2e70e9");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Mechanical",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d03c0e1b-1c97-415d-9ee4-907b81f10199"), Type = TextBlockType.Text, Text = "A hazard with this trait is a constructed physical object." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5cea5999-7908-4177-b594-7cbbc67c899a"),
                SourceId = CoreRulebook.ID,
                Page = 634
            };
        }
    }
}
