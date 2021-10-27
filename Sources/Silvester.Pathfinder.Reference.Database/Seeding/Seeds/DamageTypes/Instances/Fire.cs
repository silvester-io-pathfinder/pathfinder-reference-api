using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DamageTypes.Instances
{
    public class Fire : Template
    {
        public static readonly Guid ID = Guid.Parse("b10f2804-9573-4bbf-a11d-aeff35f6b816");

        protected override DamageType GetAction()
        {
           return new DamageType 
           { 
               Id = ID, 
               Name = "Fire",
               Description = "You resist Fire damage."
           };
        }
    }
}
