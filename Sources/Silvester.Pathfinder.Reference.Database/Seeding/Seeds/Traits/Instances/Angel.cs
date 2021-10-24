using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Angel : Template
    {
        public static readonly Guid ID = Guid.Parse("51947c16-9b13-49ae-9cf9-e181635b0560");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Angel",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("82e376ca-6418-4504-a4d9-6d73420a8c68"), Type = TextBlockType.Text, Text = "This family of celestials is native to the plane of Nirvana. Most angels are neutral good, have darkvision, and have a weakness to evil damage." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c3f0696e-0610-40cb-b2c9-3c211bbe010f"),
                SourceId = CoreRulebook.ID,
                Page = 628
            };
        }
    }
}
