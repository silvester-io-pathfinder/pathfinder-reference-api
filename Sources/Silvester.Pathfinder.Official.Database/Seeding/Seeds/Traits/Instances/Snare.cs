using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Snare : Template
    {
        public static readonly Guid ID = Guid.Parse("ece698cc-1249-402d-84c0-9b65c5f6bd5a");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Snare",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("20f149c6-fbeb-4f39-ad47-8f6e9cf854bf"), Type = TextBlockType.Text, Text = "Traps typically made by rangers, snares follow special rules that allow them to be constructed quickly and used on the battlefield." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cf21e5b7-630f-48d9-b47f-ed0bc76c1867"),
                SourceId = CoreRulebook.ID,
                Page = 636
            };
        }
    }
}
