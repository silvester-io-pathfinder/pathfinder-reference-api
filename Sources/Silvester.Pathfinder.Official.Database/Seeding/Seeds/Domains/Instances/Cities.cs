using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Domains.Instances
{
    public class Cities : Template
    {
        public static readonly Guid ID = Guid.Parse("768a6f8b-75cb-4439-a95a-1a41ef36abd8");

        protected override Domain GetDomain()
        {
            return new Domain 
            {
                Id = ID, 
                Name = "Cities", 
                Description = "You have powers over urban environments and denizens." 
            };
        }
    }
}
