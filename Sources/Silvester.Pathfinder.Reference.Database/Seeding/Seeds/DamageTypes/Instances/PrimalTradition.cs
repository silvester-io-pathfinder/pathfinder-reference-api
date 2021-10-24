using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DamageTypes.Instances
{
    public class PrimalTradition : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override DamageType GetAction()
        {
           return new DamageType 
           { 
               Id = ID,
               Name = "Primal Tradition",
               Description = "You resist damage you take from spells cast with the Primal tradition, regardless of the type of damage dealt by the spell."
           };
        }
    }
}
