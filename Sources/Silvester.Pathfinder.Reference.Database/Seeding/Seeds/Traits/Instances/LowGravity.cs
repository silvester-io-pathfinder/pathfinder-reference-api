using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class LowGravity : Template
    {
        public static readonly Guid ID = Guid.Parse("165881b6-7de2-453c-884e-4c992db9e496");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Low Gravity",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9aaff29d-db03-4b51-820d-64f8451897ec"), Type = TextBlockType.Text, Text = "Planes with this trait have gravitational forces much weaker than those on the Material Plane." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("82d6a90b-46fc-4ab0-870a-f2155cc784e6"),
                SourceId = GamemasteryGuide.ID,
                Page = 252
            };
        }
    }
}
