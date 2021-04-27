using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Darkness : AbstractTraitTemplate
    {
        public static readonly Guid ID = Guid.Parse("22d4f125-e741-46bb-bb36-fe1f4c8fa635");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Darkness",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("47fbc6ea-4925-490d-b681-f255d26f79fa"), Type = TextBlockType.Text, Text = "Darkness effects extinguish non-magical light in the area, and can counteract less powerful magical light. You must usually target light magic with your darkness magic directly to counteract the light, but some darkness spells automatically attempt to counteract light." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("99b9cf25-9a1d-4891-84b6-dbb347eecfef"),
                SourceId = CoreRulebook.ID,
                Page = 630
            };
        }
    }
}
