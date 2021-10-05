using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DamageTypes.Instances
{
    public class Bleed : Template
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
