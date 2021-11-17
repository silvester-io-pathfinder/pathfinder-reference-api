using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Village : Template
    {
        public static readonly Guid ID = Guid.Parse("39661ea5-6bba-4ea0-976b-7726da696038");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Village",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3f5183a4-09af-4ba4-b082-23c387f8f649"), Type = TextBlockType.Text, Text = "Settlements with this trait tend to be small and usually have a level no higher than 1." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("850fa529-d47f-4cbb-b5c8-06cdba0b5404"),
                SourceId = GamemasteryGuide.ID,
                Page = 255
            };
        }
    }
}
