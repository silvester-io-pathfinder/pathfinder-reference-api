using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Immunities.Instances
{
    public class Poison : Template
    {
        public static readonly Guid ID = Guid.Parse("d5f00b95-27bb-4f90-9bc2-74a0ec609638");

        protected override Immunity GetHazardImmunity()
        {
            return new Immunity 
            {
                Id = ID, 
                Name = "Poison"
            };
        }
    }
}
