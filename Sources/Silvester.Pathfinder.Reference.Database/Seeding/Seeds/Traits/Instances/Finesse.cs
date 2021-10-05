using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Finesse : Template
    {
        public static readonly Guid ID = Guid.Parse("438eae4a-2899-4298-b51d-f8aff9c504dd");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Finesse",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5ae8ebba-6d0b-4237-a643-b756067019d6"), Type = TextBlockType.Text, Text = "You can use your Dexterity modifier instead of your Strength modifier on attack rolls using this melee weapon. You still use your Strength modifier when calculating damage." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d70ea3f5-2ba4-428c-b51d-b0843361f508"),
                SourceId = CoreRulebook.ID,
                Page = 282
            };
        }
    }
}
