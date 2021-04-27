using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.DamageTypes.Instances
{
    public class Bleed : AbstractDamageTypeTemplate
    {
        public static readonly Guid ID = Guid.Parse("b084d3bf-72ac-49bc-bab2-21aa86c31fd2");

        protected override DamageType GetAction()
        {
           return new DamageType 
           {
               Id = ID, 
               Name = "Bleed" 
           };
        }
    }
}
