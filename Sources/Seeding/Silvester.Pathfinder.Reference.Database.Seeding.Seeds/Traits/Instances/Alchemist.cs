using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Alchemist : Template
    {
        public static readonly Guid ID = Guid.Parse("99d33efc-c766-4d9f-a22a-9863ff5a7ed6");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Alchemist",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("928c72d4-3925-4069-a7d1-fde5351f83d9"), Type = TextBlockType.Text, Text = "This indicates abilities from the alchemist class." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7deaf148-33ce-48db-b2da-5c13e389f3bc"),
                SourceId = CoreRulebook.ID,
                Page = 628
            };
        }
    }
}
