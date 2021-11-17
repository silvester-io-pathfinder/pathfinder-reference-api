using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Eidolon : Template
    {
        public static readonly Guid ID = Guid.Parse("580c12a2-f34e-48b4-b5ad-f14d18ef9f0b");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Eidolon",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7ef7201c-2b02-4140-b4fc-df2a06efb6a6"), Type = TextBlockType.Text, Text = "A creature with this trait is a summoner's eidolon. An item with this trait can be worn by an eidolon. An eidolon can have up to two items invested." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0f4190ef-df89-4d24-b9c0-6feaa7cdb8b6"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 253
            };
        }
    }
}
