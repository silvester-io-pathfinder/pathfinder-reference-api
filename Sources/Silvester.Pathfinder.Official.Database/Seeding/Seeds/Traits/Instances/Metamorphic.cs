using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Metamorphic : Template
    {
        public static readonly Guid ID = Guid.Parse("12fce780-8709-4837-ba3c-7be2bce3e9ee");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Metamorphic",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("61c48895-2365-459d-8a51-ca3e5c31bc91"), Type = TextBlockType.Text, Text = "On planes with this trait, the plane’s physical nature can be changed by things other than physical force or magic." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0774c69f-bfc1-4897-9d0b-103edbd28473"),
                SourceId = GamemasteryGuide.ID,
                Page = 253
            };
        }
    }
}
