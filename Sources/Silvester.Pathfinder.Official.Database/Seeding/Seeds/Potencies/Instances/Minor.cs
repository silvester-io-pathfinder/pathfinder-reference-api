using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Potencies;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Potencies.Instances
{
    public class Minor : Template
    {
        public static readonly Guid ID = Guid.Parse("d48e6d86-0396-4d4e-89dd-3396203ae7ff");

        protected override Potency GetPotency()
        {
            return new Potency
            {
                Id = ID,
                Name = "Minor",
                Order = 1
            };
        }
    }
}
