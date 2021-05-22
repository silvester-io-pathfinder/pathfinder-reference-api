using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Spriggan : Template
    {
        public static readonly Guid ID = Guid.Parse("d7edc41c-35e9-4a1d-9a5e-1021c1565704");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Spriggan",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5648b3a5-cb3b-4af1-bcdb-3337cd34043d"), Type = TextBlockType.Text, Text = "Kin to gnomes, spriggans tend to be evil and can grow in size to resemble giants." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("87304cfc-a27a-4657-9e51-d8670dff23fa"),
                SourceId = Bestiary2.ID,
                Page = 310
            };
        }
    }
}
