using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Cobbled : Template
    {
        public static readonly Guid ID = Guid.Parse("e7ad63a7-8f35-470b-9a94-04d45f3f6e2b");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Cobbled",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6459fa8b-eaf2-4f70-b9da-c2001fa72db0"), Type = TextBlockType.Text, Text = "This firearm is cobbled together and likely to misfire. No matter how well you upkeep it, on a failed attack roll, the attack misses and you must roll a DC 5 flat check. If you fail this check, the weapon misfires." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e31d58f4-5113-4033-a389-c09da15d9847"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 231
            };
        }
    }
}
