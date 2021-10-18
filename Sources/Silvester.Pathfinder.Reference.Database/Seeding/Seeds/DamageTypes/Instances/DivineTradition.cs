using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DamageTypes.Instances
{
    public class DivineTradition : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override DamageType GetAction()
        {
           return new DamageType 
           { 
               Id = ID,
               Name = "Divine Tradition",
               Description = "You resist damage you take from spells cast with the Divine tradition, regardless of the type of damage dealt by the spell."
           };
        }
    }
}
