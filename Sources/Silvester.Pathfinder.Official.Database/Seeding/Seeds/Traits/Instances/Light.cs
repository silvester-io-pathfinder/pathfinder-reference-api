using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Light : Template
    {
        public static readonly Guid ID = Guid.Parse("8b1df142-8e1c-4c4e-8ca0-f07ba4fd634c");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Light",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("178916c0-b3f4-4fe2-b84e-9889d4cd114d"), Type = TextBlockType.Text, Text = "Light effects overcome non-magical darkness in the area, and can counteract magical darkness. You must usually target darkness magic with your light magic directly to counteract the darkness, but some light spells automatically attempt to counteract darkness." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6a8e45f3-e9b7-4025-b636-6fd5a444d7e9"),
                SourceId = CoreRulebook.ID,
                Page = 633
            };
        }
    }
}
