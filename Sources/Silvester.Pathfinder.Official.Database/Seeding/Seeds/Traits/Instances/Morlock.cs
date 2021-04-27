using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Morlock : AbstractTraitTemplate
    {
        public static readonly Guid ID = Guid.Parse("d88c3ae6-6902-41f4-a7ce-27ffbabd4f87");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Morlock",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b22076b7-b6a5-4513-b96c-5ffa84269fa8"), Type = TextBlockType.Text, Text = "Morlocks are a family of pale, underground-dwelling humanoids who, generations ago, were regular humans." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("21aa6a62-f54a-40aa-b17a-8f015fcb67c2"),
                SourceId = Bestiary2.ID,
                Page = 309
            };
        }
    }
}
