using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Bulks.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.WeaponGroups.Instances;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Ammunitions.Instances
{
    public class Arrows : Template
    {
        public static readonly Guid ID = Guid.Parse("e784b731-7bb1-4e51-b438-3e88eb542a41");

        protected override Ammunition GetAmmunition()
        {
            return new Ammunition
            {
                Id = ID,
                Name = "Arrows",
                Description = "These projectiles are the ammunition for bows. The shaft of an arrow is made of wood. It is stabilized in flight by fletching at one end and bears a metal head on the other.",
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
                Id = Guid.Parse("77284f4c-a449-4276-99df-e9aa9222ff5b"),
                SourceId = CoreRulebook.ID,
                Page = 282
            };
        }
    }
}
