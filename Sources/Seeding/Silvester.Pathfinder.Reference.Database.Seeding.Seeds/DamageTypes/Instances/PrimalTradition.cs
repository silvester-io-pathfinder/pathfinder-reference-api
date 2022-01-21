using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DamageTypes.Instances
{
    public class PrimalTradition : Template
    {
        public static readonly Guid ID = Guid.Parse("283e5bc5-8968-4a30-888e-39fbfb9497db");

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
