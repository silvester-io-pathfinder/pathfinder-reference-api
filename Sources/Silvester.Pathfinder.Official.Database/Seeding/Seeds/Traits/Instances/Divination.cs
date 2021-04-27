using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Divination : AbstractTraitTemplate
    {
        public static readonly Guid ID = Guid.Parse("ce610077-804d-463e-abc8-9e6c07c05029");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Divination",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("00e18b57-6195-4c8d-bf01-375261f4665a"), Type = TextBlockType.Text, Text = "The divination school of magic typically involves obtaining or transferring information, or predicting events." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9ee41102-e7a7-4b06-8505-65f69e7b2b34"),
                SourceId = CoreRulebook.ID,
                Page = 631
            };
        }
    }
}
