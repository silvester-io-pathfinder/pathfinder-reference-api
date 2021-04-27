using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.DamageTypes.Instances
{
    public class Poison : AbstractDamageTypeTemplate
    {
        public static readonly Guid ID = Guid.Parse("38834ac6-9f9f-4b44-ad45-c2c932ff4b27");

        protected override DamageType GetAction()
        {
           return new DamageType 
           { 
               Id = ID,
               Name = "Poison" 
           };
        }
    }
}
