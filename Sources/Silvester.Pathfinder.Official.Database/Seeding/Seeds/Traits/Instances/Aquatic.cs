using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Aquatic : Template
    {
        public static readonly Guid ID = Guid.Parse("184dfff4-7374-4a6e-9518-548102eac1e4");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Aquatic",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("14cf7c7a-9547-46b5-9f3f-fe788f3fa2f0"), Type = TextBlockType.Text, Text = "Aquatic creatures are at home underwater. Their bludgeoning and slashing unarmed Strikes don’t take the usual –2 penalty for being underwater. Aquatic creatures can breathe water but not air." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3d0629bc-e207-46cb-a4e1-f7e4cd9458e1"),
                SourceId = Bestiary.ID,
                Page = 345
            };
        }
    }
}
