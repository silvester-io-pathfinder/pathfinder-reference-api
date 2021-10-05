using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.AttackTypes.Instances
{
    public class Ranged : Template
    {
        public static readonly Guid ID = Guid.Parse("4f46c206-80e8-4ff2-a3dd-e4d6a73b5388");

        protected override AttackType GetAttackType()
        {
            return new AttackType 
            {
                Id = ID,
                Name = "Ranged" 
            };
        }
    }
}
