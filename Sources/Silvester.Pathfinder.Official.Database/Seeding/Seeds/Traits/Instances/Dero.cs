using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Dero : Template
    {
        public static readonly Guid ID = Guid.Parse("e3601c4d-4e36-483e-9c7c-6be44fd9beaa");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Dero",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e8534e72-6e39-4a75-ba8b-0b76a3f826e8"), Type = TextBlockType.Text, Text = "This family of humanoids are the descendants of fey creatures that fell into darkness and confusion after being abandoned in the Darklands. They are immune to confusion and vulnerable to sunlight." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8ab8015c-6fac-4ea0-b074-de1a914910b9"),
                SourceId = Bestiary.ID,
                Page = 346
            };
        }
    }
}
