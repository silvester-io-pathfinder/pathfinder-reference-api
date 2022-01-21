using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Archon : Template
    {
        public static readonly Guid ID = Guid.Parse("8bbb6788-c4d1-4749-ad5a-054245744acc");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Archon",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c49deecc-3ad0-47fb-8dfd-3a155a57c50a"), Type = TextBlockType.Text, Text = "Members of this family of celestials are the protectors of Heaven and are lawful good. They have darkvision and a weakness to evil damage." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("03be4e06-8f89-498f-9558-165faaa27a37"),
                SourceId = CoreRulebook.ID,
                Page = 628
            };
        }
    }
}
