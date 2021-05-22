using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.DamageTypes.Instances
{
    public class Electricity : Template
    {
        public static readonly Guid ID = Guid.Parse("4b4b2444-718f-4f96-a4df-c1a3cfddf263");

        protected override DamageType GetAction()
        {
           return new DamageType 
           { 
               Id = ID,
               Name = "Electricity"
           };
        }
    }
}
