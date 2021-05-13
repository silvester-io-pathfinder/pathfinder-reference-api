using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Monk : Template
    {
        public static readonly Guid ID = Guid.Parse("20c99d83-4475-456a-aa3d-18df18dd7991");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Monk",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("25b8fb83-a52a-4b03-a134-b4526aac3c18"), Type = TextBlockType.Text, Text = "Abilities with this trait are from the monk class. A weapon with this trait is primarily used by monks." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f0ddd5fd-5112-4730-9462-854287a39905"),
                SourceId = CoreRulebook.ID,
                Page = 634
            };
        }
    }
}
