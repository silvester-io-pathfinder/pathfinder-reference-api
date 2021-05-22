using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Visual : Template
    {
        public static readonly Guid ID = Guid.Parse("dbebd472-2b53-4d66-a43d-f4f884137fea");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Visual",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("975cd0ac-a42c-4f55-a905-aeae8ebcaa15"), Type = TextBlockType.Text, Text = "A visual effect can affect only creatures that can see it. This applies only to visible parts of the effect, as determined by the GM." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("422bb46a-254e-42b9-9fcf-e0c9f04d2566"),
                SourceId = CoreRulebook.ID,
                Page = 638
            };
        }
    }
}
