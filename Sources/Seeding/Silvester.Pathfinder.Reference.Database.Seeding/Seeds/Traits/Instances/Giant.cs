using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Giant : Template
    {
        public static readonly Guid ID = Guid.Parse("07978a9c-d0d4-46ab-b003-f8bc019f3dae");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Giant",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f54796e3-027d-41b4-b224-bf229e12af1f"), Type = TextBlockType.Text, Text = "Giants are massive humanoid creatures." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cd8ed51a-2350-48d8-aa1a-1433205e39fe"),
                SourceId = CoreRulebook.ID,
                Page = 632
            };
        }
    }
}
