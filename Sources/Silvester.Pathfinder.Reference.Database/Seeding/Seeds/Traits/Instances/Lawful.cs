using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Lawful : Template
    {
        public static readonly Guid ID = Guid.Parse("7402a95c-09ac-4438-b51e-5277225ae185");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Lawful",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("04577f6a-5d15-459e-83ed-90f24c445107"), Type = TextBlockType.Text, Text = "Lawful effects often manipulate energy from law-aligned Outer Planes and are antithetical to chaotic divine servants or divine servants of chaotic deities. A creature with this trait is lawful in alignment." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("518975e8-0cb3-4aa9-8325-22cfb82af098"),
                SourceId = CoreRulebook.ID,
                Page = 633
            };
        }
    }
}
