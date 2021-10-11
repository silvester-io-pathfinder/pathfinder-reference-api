using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DamageTypes.Instances
{
    public class Cold : Template
    {
        public static readonly Guid ID = Guid.Parse("492eeb87-2bd0-4d8e-9bf1-763e083fb096");

        protected override DamageType GetAction()
        {
           return new DamageType 
           { 
               Id = ID,
               Name = "Cold"
           };
        }
    }
}
