using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Domains.Instances
{
    public class Vigil : Template
    {
        public static readonly Guid ID = Guid.Parse("c803d19e-6341-4d09-b96f-2926c23c6bcf");

        protected override Domain GetDomain()
        {
            return new Domain 
            {
                Id = ID, 
                Name = "Vigil", 
                Description = "You watch over those long passed and guard their secrets." 
            };
        }
    }
}
