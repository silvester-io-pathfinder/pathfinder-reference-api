using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DamageTypes.Instances
{
    public class Slashing : Template
    {
        public static readonly Guid ID = Guid.Parse("d047f71a-eead-4685-b09c-03e11ad29d8b");

        protected override DamageType GetAction()
        {
           return new DamageType 
           {
               Id = ID,
               Name = "Slashing"
               Description = "You resist Slashing damage."
           };
        }
    }
}
