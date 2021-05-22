using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Phantom : Template
    {
        public static readonly Guid ID = Guid.Parse("982545c1-5019-4d56-91ff-c7c202de8961");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Phantom",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("53cc0b77-216b-4df0-8794-f1360e6dce7b"), Type = TextBlockType.Text, Text = "A phantom is soul that has diverged from the River of Souls on the Ethereal Plane before being judged. They typically retain memories of their life before death, but are not undead." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("04dc755c-79f5-488f-a534-d08e6d007352"),
                SourceId = Bestiary3.ID,
                Page = 309
            };
        }
    }
}
