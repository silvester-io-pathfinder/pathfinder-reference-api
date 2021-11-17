using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Wyrwood : Template
    {
        public static readonly Guid ID = Guid.Parse("92febdb0-6336-44be-8517-98608257eed6");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Wyrwood",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c480c459-8d98-4978-92d8-882990b0c7cb"), Type = TextBlockType.Text, Text = "A wyrwood is a small, sapient living construct crafted of wood and powered with an aeon stone or a similar magical stone." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("148466a2-bcc4-4467-b321-bc3b2daa7b34"),
                SourceId = Bestiary3.ID,
                Page = 310
            };
        }
    }
}
