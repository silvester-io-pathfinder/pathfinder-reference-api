using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Evolution : Template
    {
        public static readonly Guid ID = Guid.Parse("");

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
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Feats with this trait affect your eidolon instead of you, typically by granting it additional physical capabilities." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = SecretsOfMagic.ID,
                Page = 57
            };
        }
    }
}
