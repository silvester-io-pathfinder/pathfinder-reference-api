using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Evolution : Template
    {
        public static readonly Guid ID = Guid.Parse("b91488b6-21ef-4279-9275-e76b42da39a7");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Evolution",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("dd267b6a-55b0-426b-bd6c-0299dbb8dc73"), Type = TextBlockType.Text, Text = "Feats with this trait affect your eidolon instead of you, typically by granting it additional physical capabilities." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6c951ce0-a83b-42df-a379-a3c106a69868"),
                SourceId = SecretsOfMagic.ID,
                Page = 57
            };
        }
    }
}
