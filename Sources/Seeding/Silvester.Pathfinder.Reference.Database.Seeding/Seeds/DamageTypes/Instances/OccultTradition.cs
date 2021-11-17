using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DamageTypes.Instances
{
    public class OccultTradition : Template
    {
        public static readonly Guid ID = Guid.Parse("fa78c86a-0b4e-49c0-86ab-3bef6b498344");

        protected override DamageType GetAction()
        {
           return new DamageType 
           { 
               Id = ID,
               Name = "Occult Tradition",
               Description = "You resist damage you take from spells cast with the Occult tradition, regardless of the type of damage dealt by the spell."
           };
        }
    }
}
