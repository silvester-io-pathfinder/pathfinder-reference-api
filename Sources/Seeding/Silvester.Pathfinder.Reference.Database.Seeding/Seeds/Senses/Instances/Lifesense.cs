using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Senses.Instances
{
    public class Lifesense : Template
    {
        public static readonly Guid ID = Guid.Parse("6e601b2b-181b-47fc-84d1-1db805673ef8");

        public override Sense GetSense ()
        {
            return new Sense
            {
                Id = ID,
                Name = "Lifesense"
            };
        }

        public override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("60ad90b2-2db2-40dc-8662-b7c3b4277713"), Type = TextBlockType.Text, Text = "Lifesense allows a monster to sense the vital essence of living and undead creatures within the listed range. The sense can distinguish between the positive energy animating living creatures and the negative energy animating undead creatures, much as sight distinguishes colors." };
        }

        public override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f4633305-65a9-406d-a041-7de608eef3f5"),
                SourceId = Sources.Instances.Bestiary.ID,
                Page = 343
            };
        }
    }
}
