using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Domains.Instances
{
    public class Travel : Template
    {
        public static readonly Guid ID = Guid.Parse("1a434308-2ec6-4963-aa14-b82efa52fb98");

        protected override Domain GetDomain()
        {
            return new Domain 
            { 
                Id = ID, 
                Name = "Travel", 
                Description = "You have power over movement and journeys." 
            };
        }
    }
}
