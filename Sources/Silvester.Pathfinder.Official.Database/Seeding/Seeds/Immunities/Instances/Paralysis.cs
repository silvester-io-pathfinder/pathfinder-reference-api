using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Immunities.Instances
{
    public class Paralysis : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Immunity GetHazardImmunity()
        {
            return new Immunity 
            {
                Id = ID, 
                Name = "Paralysis"
            };
        }
    }
}
