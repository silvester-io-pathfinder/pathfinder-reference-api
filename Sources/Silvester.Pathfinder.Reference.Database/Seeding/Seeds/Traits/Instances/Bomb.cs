using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Bomb : Template
    {
        public static readonly Guid ID = Guid.Parse("60266219-f1de-48d6-851d-4dec1cbcb18f");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Bomb",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0d11b7ce-4489-464b-b6c5-012e531c30bb"), Type = TextBlockType.Text, Text = "An alchemical bomb combines volatile alchemical components that explode when the bomb hits a creature or object. Most alchemical bombs deal damage, though some produce other effects." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c93330b8-6fb8-43c1-9b0c-7b72f586b78e"),
                SourceId = CoreRulebook.ID,
                Page = 629
            };
        }
    }
}
