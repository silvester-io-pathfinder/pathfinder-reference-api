using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class AntiMagical : Template
    {
        public static readonly Guid ID = Guid.Parse("e66ccbd4-49ef-4a66-921d-56d9a622997a");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Anti-Magical",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a3c45611-6155-4e50-b782-efd6dd81e63f"), Type = TextBlockType.Text, Text = "Whenever you would be affected by magic, even your own magic or that of an ally, the originator of the effect must attempt a DC 3 flat check. On a failure, the magic doesn't affect you (though it still has its normal effects on anyone else). On a success, the magic affects you and there is no need to attempt further flat checks for the same magical effect, even if it affects you again later." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fb7b002f-45a2-4e91-bf0e-39e154f95e1a"),
                SourceId = SecretsOfMagic.ID,
                Page = 30
            };
        }
    }
}
