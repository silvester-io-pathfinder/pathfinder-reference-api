using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Injury : Template
    {
        public static readonly Guid ID = Guid.Parse("88966eec-598e-44d1-b1e4-4272e4b79423");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Injury",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("926be628-eabd-4990-aa1e-af178a6fb795"), Type = TextBlockType.Text, Text = "This poison is delivered by damaging the recipient." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2ab0e3e9-9275-4158-965c-a0db914aeb8e"),
                SourceId = CoreRulebook.ID,
                Page = 633
            };
        }
    }
}
