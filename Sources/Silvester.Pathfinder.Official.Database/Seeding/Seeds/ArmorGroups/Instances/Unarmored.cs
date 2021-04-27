using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.ArmorGroups.Instances
{
    public class Unarmored : AbstractArmorGroupTemplate
    {
        public static readonly Guid ID = Guid.Parse("3e53fcd2-e07b-4af5-b331-b4372acacf74");

        protected override ArmorGroup GetArmorGroup()
        {
            return new ArmorGroup
            {
                Id = ID,
                Name = "Unarmored"
            };
        }
    }
}
