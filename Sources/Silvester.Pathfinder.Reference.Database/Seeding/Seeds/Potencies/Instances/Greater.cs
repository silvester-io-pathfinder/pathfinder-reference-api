using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Potencies.Instances
{
    public class Greater : Template
    {
        public static readonly Guid ID = Guid.Parse("8f7a4620-e8d8-432c-a0ec-5323b3cc738d");

        protected override Potency GetPotency()
        {
            return new Potency
            {
                Id = ID,
                Name = "Greater",
                Order = 4
            };
        }
    }
}
