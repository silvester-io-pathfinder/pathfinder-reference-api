using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Gremlin : Template
    {
        public static readonly Guid ID = Guid.Parse("f0c41bba-1bf6-498a-8aab-549f3555b6d5");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Gremlin",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0e537b31-fa92-4e1e-b7ee-df94a0fa87ef"), Type = TextBlockType.Text, Text = "Cruel and mischievous fey, gremlins have acclimated to life on the Material Plane." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("83b2345c-90ed-4a48-b756-58c88bdc8ea2"),
                SourceId = Bestiary.ID,
                Page = 346
            };
        }
    }
}
