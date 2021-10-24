using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DamageTypes.Instances
{
    public class PhysicalWeapon : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override DamageType GetAction()
        {
           return new DamageType 
           { 
               Id = ID,
               Name = "Physical Weapon",
               Description = "You resist physical weapon damage, but not physical damage from other sources (such as unarmed attacks)."
           };
        }
    }
}
