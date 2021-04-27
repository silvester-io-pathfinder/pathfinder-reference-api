using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Monitor : AbstractTraitTemplate
    {
        public static readonly Guid ID = Guid.Parse("fbb4ba35-fe8a-4f6b-9e11-cdadb4c6b3c1");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Monitor",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b54be341-9b36-4753-ba65-109d0a8fbdd6"), Type = TextBlockType.Text, Text = "Creatures that hail from or have a strong connection to the neutrally aligned planes are called monitors. Monitors can survive the basic environmental effects of planes in the Outer Sphere." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c9f08da5-321b-4e08-900c-443db8c98fc1"),
                SourceId = CoreRulebook.ID,
                Page = 634
            };
        }
    }
}
