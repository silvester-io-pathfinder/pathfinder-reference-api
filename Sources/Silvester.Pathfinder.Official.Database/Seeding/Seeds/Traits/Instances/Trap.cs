using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Trap : Template
    {
        public static readonly Guid ID = Guid.Parse("0b3c23de-79d0-490d-8dbb-f4840f4b5704");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Trap",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6a8c61c8-d554-4923-9acc-b5c870176a4b"), Type = TextBlockType.Text, Text = "A hazard or item with this trait is constructed to hinder interlopers." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e96f32e9-8284-4386-8080-66707738f854"),
                SourceId = CoreRulebook.ID,
                Page = 637
            };
        }
    }
}
