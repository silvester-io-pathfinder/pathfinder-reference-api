using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class AFighterditive2 : Template
    {
        public static readonly Guid ID = Guid.Parse("b78639ca-0745-40de-8940-6eadefd13753");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Fighter",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("62d0e693-87ca-4274-81c4-3143448c1f36"), Type = TextBlockType.Text, Text = "This indicates abilities from the fighter class." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("60d6ce61-0b45-4223-a7c5-36064acc5e88"),
                SourceId = CoreRulebook.ID,
                Page = 638
            };
        }
    }
}
