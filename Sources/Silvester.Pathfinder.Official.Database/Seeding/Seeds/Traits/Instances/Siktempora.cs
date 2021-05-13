using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Siktempora : Template
    {
        public static readonly Guid ID = Guid.Parse("d57e72db-d8b9-4e8a-b8b0-3c8909ea3888");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Siktempora",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8b91994a-aab6-447c-ad71-f374df29cc03"), Type = TextBlockType.Text, Text = "There was not explicit description for this trait." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("81512568-fb2f-41d7-9970-d230ea1ed678"),
                SourceId = Bestiary3.ID,
                Page = 323
            };
        }
    }
}
