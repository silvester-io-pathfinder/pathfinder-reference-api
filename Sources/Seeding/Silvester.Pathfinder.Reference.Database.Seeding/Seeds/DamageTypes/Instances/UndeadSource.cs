using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DamageTypes.Instances
{
    public class UndeadSource : Template
    {
        public static readonly Guid ID = Guid.Parse("702fb9e3-019a-4a83-aa9b-944e8cf07926");

        protected override DamageType GetAction()
        {
           return new DamageType 
           { 
               Id = ID,
               Name = "Undead Source",
               Description = "You resist damage dealt by the attacks and abilities of undead creatures, regardless of the damage type."
           };
        }
    }
}
