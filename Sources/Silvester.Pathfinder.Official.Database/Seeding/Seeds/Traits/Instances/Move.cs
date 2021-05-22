using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Move : Template
    {
        public static readonly Guid ID = Guid.Parse("d43b72ae-0105-4686-a0f9-be6e03291af2");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Move",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7295d981-91ea-401d-913b-1783b31235b7"), Type = TextBlockType.Text, Text = "An action with this trait involves moving from one space to another." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("71e8bd79-b618-4fba-8d72-14d228ac6ce6"),
                SourceId = CoreRulebook.ID,
                Page = 634
            };
        }
    }
}
