using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Bulks.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Ammunitions.Instances
{
    public class BlowgunDarts : Template
    {
        public static readonly Guid ID = Guid.Parse("9230c1f0-09ea-4dd2-b6d4-bb0cfcbeabdd");

        protected override Ammunition GetAmmunition()
        {
            return new Ammunition
            {
                Id = ID,
                Name = "Blowgun Darts",
                Description = "These thin, light darts are typically made of hardwood and stabilized with fletching of down or fur. They are often hollow so they can be used to deliver poison.",
                Price = 5,
                BatchAmount = 10,
                BulkId = LightBulk.ID,
                WeaponGroupId = WeaponGroups.Instances.Dart.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("867680b0-acc3-44c6-9e1d-0abd095af230"),
                SourceId = CoreRulebook.ID,
                Page = 281
            };
        }
    }
}
