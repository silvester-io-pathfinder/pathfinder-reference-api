using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Archetype : AbstractTraitTemplate
    {
        public static readonly Guid ID = Guid.Parse("0c6451bc-cf70-47ba-9f51-845ac61a6dbe");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Archetype",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2f960d6c-5cf6-4aa7-90ba-8bcdcb6f8efc"), Type = TextBlockType.Text, Text = "This feat belongs to an archetype." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7fdf8cf1-54dd-4f37-bd89-8eadcb87f262"),
                SourceId = CoreRulebook.ID,
                Page = 628
            };
        }
    }
}
