using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.DamageTypes.Instances
{
    public class Piercing : Template
    {
        public static readonly Guid ID = Guid.Parse("8095023e-8d92-4cdd-b294-846dc71fdb21");

        protected override DamageType GetAction()
        {
           return new DamageType 
           { 
               Id = ID, 
               Name = "Piercing" 
           };
        }
    }
}
