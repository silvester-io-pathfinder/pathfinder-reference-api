using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Dragon : Template
    {
        public static readonly Guid ID = Guid.Parse("2f4c65c4-1d67-490c-a2e1-32eb9489d9f0");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Dragon",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ed7923b7-0ffa-4f31-a609-d24c1c869024"), Type = TextBlockType.Text, Text = "Dragons are reptilian creatures, often winged or with the power of flight. Most are able to use a breath weapon and are immune to sleep and paralysis." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8c86a94a-34a6-42af-9495-6732946b2d35"),
                SourceId = CoreRulebook.ID,
                Page = 631
            };
        }
    }
}
