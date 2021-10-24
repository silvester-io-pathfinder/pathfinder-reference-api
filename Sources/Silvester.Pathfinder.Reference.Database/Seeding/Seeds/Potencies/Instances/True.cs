using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Potencies.Instances
{
    public class True : Template
    {
        public static readonly Guid ID = Guid.Parse("cf956f07-1342-4bab-ac64-d71f2832bb54");

        protected override Potency GetPotency()
        {
            return new Potency
            {
                Id = ID,
                Name = "True",
                Order = 6
            };
        }
    }
}
