using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Wand : AbstractTraitTemplate
    {
        public static readonly Guid ID = Guid.Parse("cb819435-64ff-4726-b2b3-c28669314cec");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Wand",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("cc19b2da-8180-4e91-bf31-cc7fd8f07c31"), Type = TextBlockType.Text, Text = "A wand contains a single spell which you can cast once per day." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fe77102e-7bab-4bf7-b7bc-d8f54ea9f9f8"),
                SourceId = CoreRulebook.ID,
                Page = 638
            };
        }
    }
}
