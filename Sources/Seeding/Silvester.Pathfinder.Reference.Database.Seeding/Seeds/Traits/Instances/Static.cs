using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Static : Template
    {
        public static readonly Guid ID = Guid.Parse("59e38173-01b2-4336-aa17-5d0f4a28d1cd");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Static",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("58e9cf9f-b2cb-404c-ab34-43fade68bb0e"), Type = TextBlockType.Text, Text = "The physical nature of a plane with this trait can’t be changed in any way." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("af469c75-42bb-4336-a970-608120580126"),
                SourceId = GamemasteryGuide.ID,
                Page = 254
            };
        }
    }
}
