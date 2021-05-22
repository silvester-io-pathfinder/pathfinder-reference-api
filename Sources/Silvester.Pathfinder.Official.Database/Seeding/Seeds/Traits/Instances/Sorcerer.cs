using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Sorcerer : Template
    {
        public static readonly Guid ID = Guid.Parse("043d0de7-1dde-4623-94eb-fb6d4f9d064d");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Sorcerer",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2da7fab1-ff20-4b4e-ac3d-f0fec2858898"), Type = TextBlockType.Text, Text = "This indicates abilities from the sorcerer class." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8318e74d-9b08-46ef-9e8e-74c48a388ff2"),
                SourceId = CoreRulebook.ID,
                Page = 636
            };
        }
    }
}
