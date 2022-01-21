using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Summoner : Template
    {
        public static readonly Guid ID = Guid.Parse("052d8f2c-db72-4818-864a-04e0633d0fa8");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Summoner",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("660389ec-99e3-4b4f-b84e-9a2a8f6387a1"), Type = TextBlockType.Text, Text = "This indicates abilities from the summoner class." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f6e51f28-3085-4895-a144-6db5d0514507"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 254
            };
        }
    }
}
