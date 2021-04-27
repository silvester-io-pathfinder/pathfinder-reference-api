using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Mutant : AbstractTraitTemplate
    {
        public static readonly Guid ID = Guid.Parse("31e81c2e-9c8f-4384-91de-c440782ba224");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Mutant",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b16ac749-b118-4dcf-83b3-109805add08b"), Type = TextBlockType.Text, Text = "The monster has mutated or evolved, granting it unusual benefits, drawbacks, or both." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8b1fe948-1713-4414-a4e7-52431c1fe82e"),
                SourceId = Bestiary.ID,
                Page = 347
            };
        }
    }
}
