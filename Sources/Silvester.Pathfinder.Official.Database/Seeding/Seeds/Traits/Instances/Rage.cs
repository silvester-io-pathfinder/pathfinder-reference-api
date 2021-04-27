using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Rage : AbstractTraitTemplate
    {
        public static readonly Guid ID = Guid.Parse("9a9de55e-6e46-431f-9768-b03cd01320b1");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Rage",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("41b86350-334e-4b23-ae9d-cb0aba14e054"), Type = TextBlockType.Text, Text = "You must be raging to use abilities with the rage trait, and they end automatically when you stop raging." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("00fb49ca-33fb-42e6-a6b0-c2eee291e644"),
                SourceId = CoreRulebook.ID,
                Page = 87
            };
        }
    }
}
