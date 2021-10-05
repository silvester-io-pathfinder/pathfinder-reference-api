using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Samsaran : Template
    {
        public static readonly Guid ID = Guid.Parse("febbc308-3220-4d97-9baa-160dfe75acfc");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Samsaran",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fa3682ac-7e59-4027-ac5e-dcd7921c5b5c"), Type = TextBlockType.Text, Text = "Samsarans are humanoids whose souls reincarnate into new bodies upon their death." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5aa78a47-83db-46da-b13a-1e0a94786c91"),
                SourceId = Bestiary3.ID,
                Page = 310
            };
        }
    }
}
