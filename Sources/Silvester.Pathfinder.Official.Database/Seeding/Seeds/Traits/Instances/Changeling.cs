using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Changeling : Template
    {
        public static readonly Guid ID = Guid.Parse("ea2796f7-7b9f-4bb4-b756-e35d25ef18ec");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Changeling",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("913f7c38-290b-47c4-8821-cc0cd04fec5c"), Type = TextBlockType.Text, Text = "A creature with this trait has the changeling versatile heritage. Changelings are the children of hags and members of other humanoid ancestries. An ability with this trait can be used or selected only by changelings." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2d195971-5c07-451c-83b9-5aa47ca09768"),
                SourceId = AdvancedPlayersGuide.ID,
                Page = 266
            };
        }
    }
}
