using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AttackTypes.Instances
{
    public class Melee : Template
    {
        public static readonly Guid ID = Guid.Parse("1a61a928-f75d-4c1e-b655-b92a9d40bc77");

        protected override AttackType GetAttackType()
        {
            return new AttackType 
            {
                Id = ID, 
                Name = "Melee" 
            };
        }
    }
}
