using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Senses.Instances
{
    public class Wavesense : Template
    {
        public static readonly Guid ID = Guid.Parse("3cd64ae0-6af7-4be1-a991-2a9961356ba5");

        public override Sense GetSense ()
        {
            return new Sense
            {
                Id = ID,
                Name = "Wavesense"
            };
        }

        public override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f5d558f1-8685-415e-9650-c6931cd5c10a"), Type = TextBlockType.Text, Text = "This sense allows a monster to feel vibrations caused by movement through a liquid. It's an imprecise sense with a limited range (listed in the ability). Wavesense functions only if monster and the subject are in the same body of liquid, and only if the subject is moving through the liquid." };
        }

        public override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e7a10056-de1c-425c-8600-285168f7d89a"),
                SourceId = Sources.Instances.Bestiary.ID,
                Page = 344
            };
        }
    }
}
