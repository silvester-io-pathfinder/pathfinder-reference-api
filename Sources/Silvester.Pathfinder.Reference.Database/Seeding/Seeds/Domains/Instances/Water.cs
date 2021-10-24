using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Domains.Instances
{
    public class Water : Template
    {
        public static readonly Guid ID = Guid.Parse("e41819f7-aa1b-416f-99c5-62bde7886a79");

        protected override Domain GetDomain()
        {
            return new Domain 
            {
                Id = ID, 
                Name = "Water", 
                Description = "You control water and bodies of water." 
            };
        }
    }
}
