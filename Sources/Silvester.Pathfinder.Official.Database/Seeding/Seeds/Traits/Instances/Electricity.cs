using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Electricity : Template
    {
        public static readonly Guid ID = Guid.Parse("d7e3c058-c73c-4608-a370-6835483931f8");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Electricity",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e3f352f1-ed3e-4a9b-a71d-6bcf58f53568"), Type = TextBlockType.Text, Text = "Effects with this trait deal electricity damage. A creature with this trait has a magical connection to electricity." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("41963765-fecd-4ef5-aa6c-33f4fa28bb9e"),
                SourceId = CoreRulebook.ID,
                Page = 631
            };
        }
    }
}
