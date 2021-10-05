using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Potencies.Instances
{
    public class Unclassified : Template
    {
        public static readonly Guid ID = Guid.Parse("5e2f27d1-6b8b-41a0-8f58-095a4bb926d3");

        protected override Potency GetPotency()
        {
            return new Potency
            {
                Id = ID,
                Name = "Unclassified",
                Order = 0
            };
        }
    }
}
