using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DamageTypes.Instances
{
    public class Bludgeoning : Template
    {
        public static readonly Guid ID = Guid.Parse("4712d8c3-ffe6-4db2-b28e-f94065b005bc");

        protected override DamageType GetAction()
        {
           return new DamageType 
           { 
               Id = ID,
               Name = "Bludgeoning"
               Description = "You resist Bludgeoning damage."
           };
        }
    }
}
