using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Evil : Template
    {
        public static readonly Guid ID = Guid.Parse("cee766b5-0cb1-4320-ad4e-3e625bd6e7ef");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Evil",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4495eba2-3cbc-472f-aaef-81050932b900"), Type = TextBlockType.Text, Text = "Evil effects often manipulate energy from evil-aligned Outer Planes and are antithetical to good divine servants or divine servants of good deities. A creature with this trait is evil in alignment." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("dc16f0c3-0d09-4131-9f00-4ad310f881f6"),
                SourceId = CoreRulebook.ID,
                Page = 631
            };
        }
    }
}
