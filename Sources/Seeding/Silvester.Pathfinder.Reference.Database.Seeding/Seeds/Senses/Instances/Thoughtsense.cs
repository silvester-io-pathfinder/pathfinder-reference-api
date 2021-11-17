using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Senses.Instances
{
    public class Thoughtsense : Template
    {
        public static readonly Guid ID = Guid.Parse("397b3aa4-f490-4c21-acc0-a990361ad80f");

        public override Sense GetSense ()
        {
            return new Sense
            {
                Id = ID,
                Name = "Thoughtsense"
            };
        }

        public override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5142dbd8-7dbe-40aa-9ce7-418af027d9af"), Type = TextBlockType.Text, Text = "Creatures with this ability automatically detect and locate conscious creatures within the specified range." };
        }

        public override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("aa03d09d-d0c2-4eb7-9e06-d06495d6c576"),
                SourceId = Sources.Instances.Unknown.ID
            };
        }
    }
}
