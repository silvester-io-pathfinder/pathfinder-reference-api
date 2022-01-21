using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Goloma : Template
    {
        public static readonly Guid ID = Guid.Parse("ba20c168-dfc6-4793-b35d-aefebfe9a27f");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Goloma",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c3fa30ad-1b29-441f-beab-d2096e4f0df3"), Type = TextBlockType.Text, Text = "Insular humanoids that bear countless eyes." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ad323aab-6157-4069-9b6b-2b89250e31d3"),
                SourceId = LostOmensMwangiExpanse.ID,
                Page = 309
            };
        }
    }
}
