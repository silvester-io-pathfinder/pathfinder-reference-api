using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Circus : Template
    {
        public static readonly Guid ID = Guid.Parse("6bba71cc-021c-4859-8666-784ea12d9089");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Circus",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield break;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ffd53905-425b-47ab-be29-10ba2a1c3449"),
                SourceId = Sources.Instances.Pathfinder151.ID,
                Page = 60
            };
        }
    }
}
