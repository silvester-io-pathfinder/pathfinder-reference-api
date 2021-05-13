using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Domains.Instances
{
    public class Moon : Template
    {
        public static readonly Guid ID = Guid.Parse("62a8bd3c-1541-43a7-b1ab-5e4c0b63be84");

        protected override Domain GetDomain()
        {
            return new Domain 
            {
                Id = ID, 
                Name = "Moon", 
                Description = "You command powers associated with the moon." 
            };
        }
    }
}
