using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DamageTypes.Instances
{
    public class Negative : Template
    {
        public static readonly Guid ID = Guid.Parse("d88d0bfa-b079-4ac3-8978-2c65208981ca");

        protected override DamageType GetAction()
        {
           return new DamageType 
           {
               Id = ID,
               Name = "Negative"
               Description = "You resist Negative damage."
           };
        }
    }
}
