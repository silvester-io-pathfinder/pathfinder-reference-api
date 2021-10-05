using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Sleep : Template
    {
        public static readonly Guid ID = Guid.Parse("142255e5-e9c7-4acc-af3e-3e5adce348ed");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Sleep",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0695ce17-f5b7-4ace-bd3b-6edb7fcc3267"), Type = TextBlockType.Text, Text = "This effect can cause a creature to fall asleep or get drowsy." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2c43e8ea-337c-4f95-83a2-46480b076154"),
                SourceId = CoreRulebook.ID,
                Page = 636
            };
        }
    }
}
