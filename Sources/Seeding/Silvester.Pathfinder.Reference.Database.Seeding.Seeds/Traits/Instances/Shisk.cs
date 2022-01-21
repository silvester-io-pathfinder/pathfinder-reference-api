using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Shisk : Template
    {
        public static readonly Guid ID = Guid.Parse("cc507ac9-db89-4c44-9203-8221c3d0fe10");

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
            yield return new TextBlock { Id = Guid.Parse("c91221c5-f8ce-4d9e-8dfd-268ae18fda5a"), Type = TextBlockType.Text, Text = "Secretive humanoids covered in bony plumage that reside underground." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fccb5318-0579-4f68-935b-0d79d8fde54c"),
                SourceId = LostOmensMwangiExpanse.ID,
                Page = 310
            };
        }
    }
}
