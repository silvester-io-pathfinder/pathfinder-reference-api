using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Extradimensional : AbstractTraitTemplate
    {
        public static readonly Guid ID = Guid.Parse("6361484d-f41f-425d-9222-e82596f421be");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Extradimensional",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fa2bd0ca-608a-4236-a141-a3f8afd1acc5"), Type = TextBlockType.Text, Text = "This effect or item creates an extradimensional space. An extradimensional effect placed inside another extradimensional space ceases to function until it is removed." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0324a0c8-35cb-458b-a87f-79e2740d5242"),
                SourceId = CoreRulebook.ID,
                Page = 631
            };
        }
    }
}
