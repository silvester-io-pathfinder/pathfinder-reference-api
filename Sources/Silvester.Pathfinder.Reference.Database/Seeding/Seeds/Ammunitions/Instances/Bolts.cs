using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Bulks.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponGroups.Instances;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Ammunitions.Instances
{
    public class Bolts : Template
    {
        public static readonly Guid ID = Guid.Parse("c51ef03b-db9b-44ac-92ac-39a0c7834b95");

        protected override Ammunition GetAmmunition()
        {
            return new Ammunition
            {
                Id = ID,
                Name = "Bolts",
                Description = "Shorter than traditional arrows but similar in construction, bolts are the ammunition used by crossbows.",
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
                Id = Guid.Parse("73692529-4560-47a6-988d-7e43046a44ba"),
                SourceId = CoreRulebook.ID,
                Page = 281
            };
        }
    }
}
