using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Evocation : Template
    {
        public static readonly Guid ID = Guid.Parse("16d2758a-935b-4552-b8ae-7eb36d6bf3d1");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Evocation",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1f28b7db-8b35-49bc-a5e6-3fb78bd3a9e7"), Type = TextBlockType.Text, Text = "Effects and magic items with this trait are associated with the evocation school of magic, typically involving energy and elemental forces." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("94380464-5e98-4584-bb5f-97820b07eb1a"),
                SourceId = CoreRulebook.ID,
                Page = 631
            };
        }
    }
}
