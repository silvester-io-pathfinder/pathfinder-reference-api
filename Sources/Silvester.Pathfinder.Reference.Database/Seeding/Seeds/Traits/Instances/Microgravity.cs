using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Microgravity : Template
    {
        public static readonly Guid ID = Guid.Parse("c4f96a94-62fd-4069-9598-58ecda44ca3d");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Microgravity",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2847b7b4-22cd-4e82-b635-53e28a966d76"), Type = TextBlockType.Text, Text = "Planes with this trait have little to no gravity." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c5ef714b-0f14-401b-9ce5-d0df13a32773"),
                SourceId = GamemasteryGuide.ID,
                Page = 253
            };
        }
    }
}
