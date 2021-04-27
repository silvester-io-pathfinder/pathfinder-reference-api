using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Abjuration : AbstractTraitTemplate
    {
        public static readonly Guid ID = Guid.Parse("029497fa-5a49-4a89-bfc3-68a2e57f765a");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Abjuration",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f77f6e3f-1cc9-4255-8ea8-e1a199c557bc"), Type = TextBlockType.Text, Text = "Effects and magic items with this trait are associated with the abjuration school of magic, typically involving protection or wards." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("40d92c0e-f2c3-4b0b-bca4-21d2875c8504"),
                SourceId = CoreRulebook.ID,
                Page = 628
            };
        }
    }
}
