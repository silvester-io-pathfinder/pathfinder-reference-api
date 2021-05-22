using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Charauka : Template
    {
        public static readonly Guid ID = Guid.Parse("e77d5514-3bd5-40a9-ad28-d7ee55136071");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Charau-Ka",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("03a7fb4f-b42d-4b62-b49d-eea4430128d2"), Type = TextBlockType.Text, Text = "There was not explicit description for this trait." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d4a663b7-b750-4bab-9f7a-d2203fc86686"),
                SourceId = CoreRulebook.ID,
                Page = 636
            };
        }
    }
}
