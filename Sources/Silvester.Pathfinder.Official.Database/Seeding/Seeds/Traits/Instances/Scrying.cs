using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Scrying : AbstractTraitTemplate
    {
        public static readonly Guid ID = Guid.Parse("a8667405-868d-4adb-a5b4-8542cda35792");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Scrying",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("cf4db94b-2c57-45f1-b132-933d8e3a2825"), Type = TextBlockType.Text, Text = "A scrying effect lets you see, hear, or otherwise get sensory information from a distance using a sensor or apparatus, rather than your own eyes and ears." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("04dc9285-9bc1-45f1-893d-9b64aa884d69"),
                SourceId = CoreRulebook.ID,
                Page = 636
            };
        }
    }
}
