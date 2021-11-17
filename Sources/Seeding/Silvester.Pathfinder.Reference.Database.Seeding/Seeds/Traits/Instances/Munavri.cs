using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Munavri : Template
    {
        public static readonly Guid ID = Guid.Parse("820cc332-9efd-4ea9-9590-0644bd1f8e8a");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Munavri",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("80832cd0-0ab9-43c2-88ef-988436465881"), Type = TextBlockType.Text, Text = "Amicable humanoids living in the Darklands, munavris have powerful telekinetic and psychic abilities." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("30491fbc-63aa-40b2-89a0-d32d6e3effb1"),
                SourceId = Bestiary3.ID,
                Page = 309
            };
        }
    }
}
