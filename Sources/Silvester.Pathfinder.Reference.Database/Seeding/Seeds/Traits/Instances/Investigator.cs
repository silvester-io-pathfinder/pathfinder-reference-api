using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Investigator : Template
    {
        public static readonly Guid ID = Guid.Parse("48ba8c69-63f3-4d36-8d61-781b4cbd8dba");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Investigator",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ccdb5499-971a-4833-accb-d7ca9cb7d09d"), Type = TextBlockType.Text, Text = "This trait indicates abilities from the investigator class." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a96d48ca-397d-47e0-b92b-d87a8f983dd6"),
                SourceId = AdvancedPlayersGuide.ID,
                Page = 268
            };
        }
    }
}
