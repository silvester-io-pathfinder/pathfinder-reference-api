using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DamageTypes.Instances
{
    public class Piercing : Template
    {
        public static readonly Guid ID = Guid.Parse("8095023e-8d92-4cdd-b294-846dc71fdb21");

        protected override DamageType GetAction()
        {
           return new DamageType 
           { 
               Id = ID, 
               Name = "Piercing"
               Description = "You resist Piercing damage."
           };
        }
    }
}
