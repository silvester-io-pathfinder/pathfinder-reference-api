using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Immunities.Instances
{
    public class ObjectImmunities : Template
    {
        public static readonly Guid ID = Guid.Parse("b4be6e7f-41de-4943-b277-9fff8f56a398");

        protected override Immunity GetHazardImmunity()
        {
            return new Immunity 
            {
                Id = ID, 
                Name = "Object Immunities" 
            };
        }
    }
}
