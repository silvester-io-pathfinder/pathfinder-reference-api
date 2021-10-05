using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Open : Template
    {
        public static readonly Guid ID = Guid.Parse("faca39bc-dc55-4454-9730-00c3bcde55e1");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Open",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ce9b2967-7fb4-4e1c-a84e-dc894f250a84"), Type = TextBlockType.Text, Text = "These maneuvers work only as the first salvo on your turn. You can use an open only if you haven’t used an action with the attack or open trait yet this turn." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("17c3cced-12a0-4999-81f1-e80826b0a5ff"),
                SourceId = CoreRulebook.ID,
                Page = 634
            };
        }
    }
}
