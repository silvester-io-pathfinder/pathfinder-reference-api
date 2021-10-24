using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Poison : Template
    {
        public static readonly Guid ID = Guid.Parse("c3b0ee13-49dd-4188-be4f-063d800c22a9");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Poison",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("61e028bb-2688-42c4-b53e-dcad9c0d7630"), Type = TextBlockType.Text, Text = "An effect with this trait delivers a poison or deals poison damage. An item with this trait is poisonous and might cause an affliction." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2a1a30e7-8a86-4b9a-8c0c-dd661d667017"),
                SourceId = CoreRulebook.ID,
                Page = 635
            };
        }
    }
}
