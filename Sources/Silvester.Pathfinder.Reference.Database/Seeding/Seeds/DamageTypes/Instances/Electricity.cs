using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DamageTypes.Instances
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
               Description = "You resist Electricity damage."
           };
        }
    }
}
