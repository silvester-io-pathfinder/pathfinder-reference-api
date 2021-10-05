using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Immunities.Instances
{
    public class PrecisionDamage : Template
    {
        public static readonly Guid ID = Guid.Parse("d9423d3e-cf11-4bd0-9789-89dd60fe61b0");

        protected override Immunity GetHazardImmunity()
        {
            return new Immunity 
            {
                Id = ID, 
                Name = "Precision Damage" 
            };
        }
    }
}
