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
    public class RepeatingHandCrossbowMagazine : AbstractAmmunitionsTemplate
    {
        public static readonly Guid ID = Guid.Parse("5ee1520e-e377-4855-8e73-81ebee4c146d");

        protected override Ammunition GetAmmunition()
        {
            return new Ammunition
            {
                Id = ID,
                Name = "Repeating Hand Crossbow Magazine",
                Description = "A typical repeating hand crossbow magazine holds five bolts.",
                Price = 90,
                BatchAmount = 5,
                BulkId = NegligibleBulk.ID,
                WeaponGroupId = Bow.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("91b5e6aa-fe9b-4f36-8a57-d7588c7b876f"),
                SourceId = Pathfinder165.ID,
                Page = 73
            };
        }
    }
}
