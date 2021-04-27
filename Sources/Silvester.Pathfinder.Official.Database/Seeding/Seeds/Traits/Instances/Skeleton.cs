using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Skeleton : AbstractTraitTemplate
    {
        public static readonly Guid ID = Guid.Parse("ddaf1aee-4cf4-41e5-895b-c04e8225f0b3");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Skeleton",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("34c84246-8f5f-4086-bd3f-aa849911ae2f"), Type = TextBlockType.Text, Text = "This undead is made by animating a dead creature’s skeleton with negative energy." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c837682b-138c-4b07-a352-889f32545a5d"),
                SourceId = Bestiary.ID,
                Page = 347
            };
        }
    }
}
