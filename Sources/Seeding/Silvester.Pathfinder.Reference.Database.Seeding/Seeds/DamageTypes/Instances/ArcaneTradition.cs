using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DamageTypes.Instances
{
    public class ArcaneTradition : Template
    {
        public static readonly Guid ID = Guid.Parse("0b6f0ef6-2c24-4024-83de-db61935fc4d3");

        protected override DamageType GetAction()
        {
           return new DamageType 
           { 
               Id = ID,
               Name = "Arcane Tradition",
               Description = "You resist damage you take from spells cast with the Arcane tradition, regardless of the type of damage dealt by the spell."
           };
        }
    }
}
