using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Emotion : Template
    {
        public static readonly Guid ID = Guid.Parse("df5af144-0177-4922-a7e8-37c9e0c99708");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Emotion",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9b3da9b6-f2b5-4388-ab10-2efed1663eba"), Type = TextBlockType.Text, Text = "This effect alters a creature's emotions. Effects with this trait always have the mental trait as well. Creatures with special training or that have mechanical or artificial intelligence are immune to emotion effects." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f0639ef0-8bd3-4c56-9a3f-d34ca8b4b7b2"),
                SourceId = CoreRulebook.ID,
                Page = 631
            };
        }
    }
}
