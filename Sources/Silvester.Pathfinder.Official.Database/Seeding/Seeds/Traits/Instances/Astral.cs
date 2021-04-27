using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Astral : AbstractTraitTemplate
    {
        public static readonly Guid ID = Guid.Parse("9f37fa8f-67c7-4b18-8410-c3c1fec6f873");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Astral",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b7877500-5942-428f-b6c5-668f28e1091d"), Type = TextBlockType.Text, Text = "Astral creatures are native of the Astral Plane. They can survive the basic environmental effects of the Astral Plane." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ccf1c4d6-969b-4814-baaf-1605942ca806"),
                SourceId = CoreRulebook.ID,
                Page = 628
            };
        }
    }
}
