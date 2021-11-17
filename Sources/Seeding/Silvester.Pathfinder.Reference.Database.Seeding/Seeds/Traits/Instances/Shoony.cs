using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Shoony : Template
    {
        public static readonly Guid ID = Guid.Parse("7e07fa4f-30da-4b49-977a-6ca15743ccba");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Shoony",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3748d4f7-2335-449d-9eb3-a4aceb07d8bf"), Type = TextBlockType.Text, Text = "There was not explicit description for this trait." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ffe14b0c-1724-4730-bfdb-0d0b41d55727"),
                SourceId = Pathfinder153.ID,
                Page = 70
            };
        }
    }
}
