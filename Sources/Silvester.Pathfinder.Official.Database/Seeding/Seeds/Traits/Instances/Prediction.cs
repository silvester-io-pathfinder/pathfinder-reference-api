using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Prediction : AbstractTraitTemplate
    {
        public static readonly Guid ID = Guid.Parse("cd9897ab-afd4-4905-b9d5-da1d7606242a");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Prediction",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("38ede88d-cf05-46ca-8dbf-23e2c6960204"), Type = TextBlockType.Text, Text = "Effects with this trait determine what is likely to happen in the near future. Most predictions are divinations." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cc0b87ac-fb6d-472a-8d6c-446d12702e34"),
                SourceId = CoreRulebook.ID,
                Page = 635
            };
        }
    }
}
