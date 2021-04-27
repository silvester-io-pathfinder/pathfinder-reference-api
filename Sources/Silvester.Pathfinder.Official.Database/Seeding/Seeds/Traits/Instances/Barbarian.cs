using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Barbarian : AbstractTraitTemplate
    {
        public static readonly Guid ID = Guid.Parse("0dcbd033-b10d-44e7-87f0-5a7e5214d041");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Barbarian",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2f59496f-49f3-4452-b4b1-b9e73a02d065"), Type = TextBlockType.Text, Text = "This indicates abilities from the barbarian class." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a838f6e4-249b-4f1c-96b0-e191d458a533"),
                SourceId = CoreRulebook.ID,
                Page = 629
            };
        }
    }
}
