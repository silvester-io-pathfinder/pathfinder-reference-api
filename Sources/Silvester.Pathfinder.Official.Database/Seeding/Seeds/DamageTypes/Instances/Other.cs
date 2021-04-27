using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.DamageTypes.Instances
{
    public class Other : AbstractDamageTypeTemplate
    {
        public static readonly Guid ID = Guid.Parse("ce414c75-a03c-4602-a0e0-8d81ac980fc5");

        protected override DamageType GetAction()
        {
           return new DamageType 
           { 
               Id = ID, 
               Name = "Other"
           };
        }
    }
}
