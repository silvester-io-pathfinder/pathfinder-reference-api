using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Primal : AbstractTraitTemplate
    {
        public static readonly Guid ID = Guid.Parse("72009be6-d14a-4a2f-8ba4-15e7fa2b8dbe");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Primal",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9b00cac3-75dd-4c96-af88-d1be82f1aa8f"), Type = TextBlockType.Text, Text = "This magic comes from the primal tradition, connecting to the natural world and instinct. Anything with this trait is magical." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c4016ff7-045f-45ca-9411-1ffe8e39081b"),
                SourceId = CoreRulebook.ID,
                Page = 635
            };
        }
    }
}
