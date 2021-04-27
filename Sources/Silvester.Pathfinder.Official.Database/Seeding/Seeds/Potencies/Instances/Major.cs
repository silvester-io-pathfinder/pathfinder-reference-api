using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Potencies;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Potencies.Instances
{
    public class Major : AbstractPotencyTemplate
    {
        public static readonly Guid ID = Guid.Parse("4852d7fd-20c3-442e-99c2-44416cf925ba");

        protected override Potency GetPotency()
        {
            return new Potency
            {
                Id = ID,
                Name = "Major"
            };
        }
    }
}
