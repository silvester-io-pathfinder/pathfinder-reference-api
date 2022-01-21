using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Domains.Instances
{
    public class Zeal : Template
    {
        public static readonly Guid ID = Guid.Parse("1fc1a8d3-cf3d-4e81-a1d5-f737a2e747f6");

        protected override Domain GetDomain()
        {
            return new Domain 
            {
                Id = ID, 
                Name = "Zeal", 
                Description = "Your inner fire increases your combat prowess." 
            };
        }
    }
}
