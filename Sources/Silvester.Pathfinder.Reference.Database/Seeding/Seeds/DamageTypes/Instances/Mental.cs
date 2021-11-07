using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DamageTypes.Instances
{
    public class Mental : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override DamageType GetAction()
        {
           return new DamageType 
           {
               Id = ID, 
               Name = "Mental",
               Description = "A mental effect can alter the target's mind. It has no effect on an object or a mindless creature."
           };
        }
    }
}
