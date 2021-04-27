using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Golem : AbstractTraitTemplate
    {
        public static readonly Guid ID = Guid.Parse("d44ea313-6b89-4f9e-99ae-0d7d09c84245");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Golem",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("592c961a-709a-4b77-aa29-04bd45111948"), Type = TextBlockType.Text, Text = "Golems are a special type of construct. Golems are immune to almost all magic, but most have a weakness to certain spells." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bf68520a-dcaa-4133-b4be-e61fa7bf548a"),
                SourceId = Bestiary.ID,
                Page = 346
            };
        }
    }
}
