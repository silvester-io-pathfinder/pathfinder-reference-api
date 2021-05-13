using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Chaotic : Template
    {
        public static readonly Guid ID = Guid.Parse("cef41071-5af2-47d7-8e60-b191bfc11d11");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Chaotic",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("76652546-26ed-43b8-a366-08feb1dbf332"), Type = TextBlockType.Text, Text = "Chaotic effects often manipulate energy from chaos-aligned Outer Planes and are anathema to lawful divine servants or divine servants of lawful deities. A creature with this trait is chaotic in alignment." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fc43af05-154b-4ed7-8d9b-df17f0a5dc6f"),
                SourceId = CoreRulebook.ID,
                Page = 629
            };
        }
    }
}
