using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class HalfOrc : Template
    {
        public static readonly Guid ID = Guid.Parse("de6ac5ab-22d1-4f10-b94d-07ea9ce22778");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Half-Orc",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9e0643e4-c36b-47ab-afeb-dc8de5df6058"), Type = TextBlockType.Text, Text = "A creature with this trait is part human and part orc. An ability with this trait can be used or selected only by half-orcs." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7b193013-0e6e-4629-b51c-bbc352beb68d"),
                SourceId = CoreRulebook.ID,
                Page = 632
            };
        }
    }
}
