using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Good : Template
    {
        public static readonly Guid ID = Guid.Parse("b3fff128-4e31-483e-be2a-6b9d769ced22");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Good",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("70dca6af-f677-47cd-b3a3-5d81369edc61"), Type = TextBlockType.Text, Text = "Good effects often manipulate energy from good-aligned Outer Planes and are antithetical to evil divine servants or divine servants of evil deities. A creature with this trait is good in alignment." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f1700c40-e8ff-47a9-a84c-63b999e5dd24"),
                SourceId = CoreRulebook.ID,
                Page = 632
            };
        }
    }
}
