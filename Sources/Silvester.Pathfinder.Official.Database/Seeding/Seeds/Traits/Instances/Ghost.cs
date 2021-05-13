using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Ghost : Template
    {
        public static readonly Guid ID = Guid.Parse("a8d6ec41-7cb7-4738-af55-09955cb7ad30");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Ghost",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("713f0a5d-8455-4ee0-b0e3-b9edc9b8d0a3"), Type = TextBlockType.Text, Text = "Lost souls that haunt the world as incorporeal undead are called ghosts." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b51da63a-ef42-4dce-bf81-dbd5b36bebd3"),
                SourceId = Bestiary.ID,
                Page = 346
            };
        }
    }
}
