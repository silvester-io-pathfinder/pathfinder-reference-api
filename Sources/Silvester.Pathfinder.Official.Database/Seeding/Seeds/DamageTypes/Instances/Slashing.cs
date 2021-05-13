using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.DamageTypes.Instances
{
    public class Slashing : Template
    {
        public static readonly Guid ID = Guid.Parse("d047f71a-eead-4685-b09c-03e11ad29d8b");

        protected override DamageType GetAction()
        {
           return new DamageType 
           {
               Id = ID,
               Name = "Slashing" 
           };
        }
    }
}
