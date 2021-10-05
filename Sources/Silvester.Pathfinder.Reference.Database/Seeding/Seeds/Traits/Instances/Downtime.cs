using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Downtime : Template
    {
        public static readonly Guid ID = Guid.Parse("410c89bb-2b0f-4295-a63e-f7864e75581f");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Downtime",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a01f65af-1378-4ba0-bd4b-dbe77c561e5f"), Type = TextBlockType.Text, Text = "An activity with this trait takes a day or more, and can be used only during downtime." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5f98830d-ad51-4d69-b714-bd079a2faeb3"),
                SourceId = CoreRulebook.ID,
                Page = 631
            };
        }
    }
}
