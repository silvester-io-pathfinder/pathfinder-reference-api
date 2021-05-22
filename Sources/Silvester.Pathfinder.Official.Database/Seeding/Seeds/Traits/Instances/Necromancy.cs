using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Necromancy : Template
    {
        public static readonly Guid ID = Guid.Parse("d47884e5-93b9-4fe7-8647-7a07ef5d6a18");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Necromancy",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d2ddd9bf-d0f1-49fd-bc09-aacdf2652d74"), Type = TextBlockType.Text, Text = "Effects and magic items with this trait are associated with the necromancy school of magic, typically involving forces of life and death." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("477001ab-3d59-48bc-b217-acef22d1df56"),
                SourceId = CoreRulebook.ID,
                Page = 634
            };
        }
    }
}
