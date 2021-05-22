using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Immunities.Instances
{
    public class Mental : Template
    {
        public static readonly Guid ID = Guid.Parse("6db6971f-5d71-46e0-8f4f-414f8fd618de");

        protected override Immunity GetHazardImmunity()
        {
            return new Immunity 
            {
                Id = ID, 
                Name = "Mental"
            };
        }
    }
}
