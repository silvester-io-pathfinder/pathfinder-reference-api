using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Immunities.Instances
{
    public class Unconscious : Template
    {
        public static readonly Guid ID = Guid.Parse("60fa2654-5f7d-4a57-8ebb-09c5a5c64ce2");

        protected override Immunity GetHazardImmunity()
        {
            return new Immunity 
            {
                Id = ID, 
                Name = "Unconscious"
            };
        }
    }
}
