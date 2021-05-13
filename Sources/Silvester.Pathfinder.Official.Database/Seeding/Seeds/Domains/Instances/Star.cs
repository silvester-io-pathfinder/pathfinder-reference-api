using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Domains.Instances
{
    public class Star : Template
    {
        public static readonly Guid ID = Guid.Parse("da053ff5-4d67-4b00-bce6-19eb9a5f94bd");

        protected override Domain GetDomain()
        {
            return new Domain 
            { 
                Id = ID, 
                Name = "Star", 
                Description = "You command the power of the stars." 
            };
        }
    }
}
