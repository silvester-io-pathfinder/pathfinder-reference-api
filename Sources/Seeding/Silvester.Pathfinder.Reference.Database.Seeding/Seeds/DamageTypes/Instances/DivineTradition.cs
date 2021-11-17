using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DamageTypes.Instances
{
    public class DivineTradition : Template
    {
        public static readonly Guid ID = Guid.Parse("db4c62bc-cc42-4387-aa08-1c9f007f3291");

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
