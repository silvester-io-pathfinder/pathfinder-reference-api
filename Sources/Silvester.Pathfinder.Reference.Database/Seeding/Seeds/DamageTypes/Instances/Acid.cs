using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DamageTypes.Instances
{
    public class Acid : Template
    {
        public static readonly Guid ID = Guid.Parse("24e43bdc-5c89-4d69-9984-24723cf25d9d");

        protected override DamageType GetAction()
        {
           return new DamageType 
           {
               Id = ID, 
               Name = "Acid"
           };
        }
    }
}
