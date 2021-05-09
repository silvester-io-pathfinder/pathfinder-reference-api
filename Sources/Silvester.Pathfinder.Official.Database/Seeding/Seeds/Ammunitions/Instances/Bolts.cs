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
    public class Bolts : AbstractAmmunitionsTemplate
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
