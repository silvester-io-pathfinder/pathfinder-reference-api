using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Metropolis : Template
    {
        public static readonly Guid ID = Guid.Parse("07506b85-4174-42cb-a3e9-769651bb7876");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Metropolis",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("79d3e0dd-182e-4975-ab4a-326fe0446461"), Type = TextBlockType.Text, Text = "Settlements with this trait are the largest of cities, often with a level of 8 or higher." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2f2b6fa5-ebf2-401a-900e-2e1176b98265"),
                SourceId = GamemasteryGuide.ID,
                Page = 253
            };
        }
    }
}
