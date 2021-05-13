using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Complex : Template
    {
        public static readonly Guid ID = Guid.Parse("16172afd-7325-48e0-a180-93bbba16d5ca");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Complex",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4911acd5-87b3-460f-8ce1-dd2ca1be39d4"), Type = TextBlockType.Text, Text = "A hazard with this trait takes turns in an encounter." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bb2e8b2c-ce59-42bb-b991-e928cdb4c346"),
                SourceId = CoreRulebook.ID,
                Page = 629
            };
        }
    }
}
