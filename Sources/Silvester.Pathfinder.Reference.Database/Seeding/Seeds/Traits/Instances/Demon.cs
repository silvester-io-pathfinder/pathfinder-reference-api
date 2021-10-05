using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Demon : Template
    {
        public static readonly Guid ID = Guid.Parse("b13e7ac3-cd40-4688-858d-f0fa3b00bf2e");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Demon",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4cb57519-a9bf-4d34-bdd6-69300689486a"), Type = TextBlockType.Text, Text = "A family of fiends, demons hail from or trace their origins to the Abyss. Most are irredeemably chaotic evil and have darkvision." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6a3a1acd-2e4a-4040-ae8a-6907af7a3717"),
                SourceId = CoreRulebook.ID,
                Page = 630
            };
        }
    }
}
