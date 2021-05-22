using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Wayang : Template
    {
        public static readonly Guid ID = Guid.Parse("b9e4c779-e070-49d0-abba-5268ca479d11");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Wayang",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b508508e-6ef7-4658-b661-e397d7ee1c01"), Type = TextBlockType.Text, Text = "Small humanoids who emigrated from the Shadow Plane long ago, wayangs still wield shadow magic." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3fc83cf7-b2da-4d57-a002-0a7b50e14786"),
                SourceId = Bestiary3.ID,
                Page = 310
            };
        }
    }
}
