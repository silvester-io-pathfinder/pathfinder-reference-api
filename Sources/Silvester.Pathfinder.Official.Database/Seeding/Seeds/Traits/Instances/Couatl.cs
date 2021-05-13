using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Couatl : Template
    {
        public static readonly Guid ID = Guid.Parse("53781661-e0ae-4d23-816a-41839c2f566c");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Couatl",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0c0575ba-ad2f-447a-9b07-3a7efe1f41e0"), Type = TextBlockType.Text, Text = "A family of supernatural feathered serpents who serve as guardians and messengers on the Material Plane for various good-aligned divinities." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8810570d-717c-4686-bc2a-93b893e2bedb"),
                SourceId = Bestiary2.ID,
                Page = 308
            };
        }
    }
}
