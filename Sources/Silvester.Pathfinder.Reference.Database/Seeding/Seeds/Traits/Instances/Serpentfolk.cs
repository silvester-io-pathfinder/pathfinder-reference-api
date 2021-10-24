using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Serpentfolk : Template
    {
        public static readonly Guid ID = Guid.Parse("369aafeb-f943-4522-8c5a-56b4a515be33");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Serpentfolk",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("25ca15e7-3ce8-4f3b-ae52-e1e9038b1c76"), Type = TextBlockType.Text, Text = "Serpentfolk are a family of serpentine humanoids." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5d79f033-44da-4061-8724-c9d487c393c6"),
                SourceId = Bestiary2.ID,
                Page = 309
            };
        }
    }
}
