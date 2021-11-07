using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Shisk : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Shisk",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Secretive humanoids covered in bony plumage that reside underground." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = LostOmensMwangiExpanse.ID,
                Page = 310
            };
        }
    }
}
