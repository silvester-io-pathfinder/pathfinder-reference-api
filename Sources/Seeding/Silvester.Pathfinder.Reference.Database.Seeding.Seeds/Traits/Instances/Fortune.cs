using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Fortune : Template
    {
        public static readonly Guid ID = Guid.Parse("242c1cf5-3168-473e-ae16-c375594352e0");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Fortune",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8b837808-9adb-44be-8371-e6a9e5f0bbfd"), Type = TextBlockType.Text, Text = "A fortune effect beneficially alters how you roll your dice. You can never have more than one fortune effect alter a single roll. If multiple fortune effects would apply, you have to pick which to use. If a fortune effect and a misfortune effect would apply to the same roll, the two cancel each other out, and you roll normally." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e066d5be-369f-4f9e-9925-10b236c9ec1c"),
                SourceId = CoreRulebook.ID,
                Page = 632
            };
        }
    }
}
