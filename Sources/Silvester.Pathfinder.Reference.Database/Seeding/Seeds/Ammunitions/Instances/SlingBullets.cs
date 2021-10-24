using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Bulks.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Ammunitions.Instances
{
    public class SlingBullets : Template
    {
        public static readonly Guid ID = Guid.Parse("550fe4e4-da65-4660-93bb-03676930ac11");

        protected override Ammunition GetAmmunition()
        {
            return new Ammunition
            {
                Id = ID,
                Name = "Sling Bullets",
                Description = "These are small metal balls, typically either iron or lead, designed to be used as ammunition in slings.",
                Price = 1,
                BatchAmount = 10,
                BulkId = LightBulk.ID,
                WeaponGroupId = WeaponGroups.Instances.Sling.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("489605ad-2019-4607-b4b5-dd06a348fb01"),
                SourceId = CoreRulebook.ID,
                Page = 282
            };
        }
    }
}
