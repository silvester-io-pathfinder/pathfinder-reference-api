using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Humanoid : AbstractTraitTemplate
    {
        public static readonly Guid ID = Guid.Parse("1085d8c5-4223-408b-8016-681c28237248");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Humanoid",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("03275420-8229-4ffb-add5-90cccef19b5b"), Type = TextBlockType.Text, Text = "Humanoid creatures reason and act much like humans. They typically stand upright and have two arms and two legs." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4e1aa90d-90ca-414c-8a4f-7b9d170149a8"),
                SourceId = CoreRulebook.ID,
                Page = 633
            };
        }
    }
}
