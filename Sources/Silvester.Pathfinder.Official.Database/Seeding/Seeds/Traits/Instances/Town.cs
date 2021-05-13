using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Town : Template
    {
        public static readonly Guid ID = Guid.Parse("81a8c31f-4d7a-4395-b9d0-c398a060c913");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Town",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6aae9e73-0267-4911-9c11-eba84d036de5"), Type = TextBlockType.Text, Text = "Settlements with this trait are modest in size, with a level usually ranging from 2–4." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("af1d0e00-1988-4813-b4fa-48b83b0a6423"),
                SourceId = GamemasteryGuide.ID,
                Page = 254
            };
        }
    }
}
