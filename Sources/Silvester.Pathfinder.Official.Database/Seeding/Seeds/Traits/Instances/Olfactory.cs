using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Olfactory : AbstractTraitTemplate
    {
        public static readonly Guid ID = Guid.Parse("39bf6574-c7a0-4edb-b668-df36969d6b8c");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Olfactory",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2799f06d-d7e6-4461-a614-5b30c0ff1d48"), Type = TextBlockType.Text, Text = "An olfactory effect can affect only creatures that can smell it. This applies only to olfactory parts of the effect, as determined by the GM." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e0b9fd22-e5b0-4218-bdf9-6d1d9b339e23"),
                SourceId = Bestiary.ID,
                Page = 168
            };
        }
    }
}
