using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Hampering : AbstractTraitTemplate
    {
        public static readonly Guid ID = Guid.Parse("6b08aa5d-7dc6-4dec-bb51-0a0aa0ab925d");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Hampering",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8caec97b-bcb4-42a5-9d2c-e42db6d4e74a"), Type = TextBlockType.Text, Text = "A creature with this trait is a member of the halfling ancestry. These small people are friendly wanderers considered to be lucky. An ability with this trait can be used or selected only by halflings. A weapon with this trait is created and used by halflings." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("99ed2ebb-9681-4967-8270-0a253822e383"),
                SourceId = CoreRulebook.ID,
                Page = 632
            };
        }
    }
}
