using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DamageTypes.Instances
{
    public class Other : Template
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
