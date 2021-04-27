using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.HazardImmunities.Instances
{
    public class PrecisionDamage : AbstractHazardImmunityTemplate
    {
        public static readonly Guid ID = Guid.Parse("d9423d3e-cf11-4bd0-9789-89dd60fe61b0");

        protected override HazardImmunity GetHazardImmunity()
        {
            return new HazardImmunity 
            {
                Id = ID, 
                Name = "Precision Damage" 
            };
        }
    }
}
