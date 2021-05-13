using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Plant : Template
    {
        public static readonly Guid ID = Guid.Parse("4446ca5a-97e7-408d-aac9-4f19571e5cbc");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Plant",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ee13449c-bb3a-4ee7-8c2a-1b213b6cd30c"), Type = TextBlockType.Text, Text = "Vegetable creatures have the plant trait. They are distinct from normal plants. Magical effects with this trait manipulate or conjure plants or plant matter in some way. Those that manipulate plants have no effect in an area with no plants." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("76508c14-6786-49da-ac91-91a38fcb668a"),
                SourceId = CoreRulebook.ID,
                Page = 635
            };
        }
    }
}
