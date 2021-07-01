using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Bulks.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.WeaponGroups.Instances;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Ammunitions.Instances
{
    public class WoodenTaws : Template
    {
        public static readonly Guid ID = Guid.Parse("2981098c-b7f9-40bd-83a4-624eec7ef483");

        protected override Ammunition GetAmmunition()
        {
            return new Ammunition
            {
                Id = ID,
                Name = "Wooden Taws",
                Description = "No description was provided for this ammunition.",
                Price = 10,
                BatchAmount = 10,
                BulkId = LightBulk.ID,
                WeaponGroupId = Bow.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f1971ded-4ed2-4256-9dc7-4887b0867100"),
                SourceId = CoreRulebook.ID,
                Page = 282
            };
        }
    }
}
