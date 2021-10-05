using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Domains.Instances
{
    public class Nature : Template
    {
        public static readonly Guid ID = Guid.Parse("ab621b51-801a-4e47-9581-c7fa211731b3");

        protected override Domain GetDomain()
        {
            return new Domain 
            {
                Id = ID, 
                Name = "Nature", 
                Description = "You hold power over animals and plants." 
            };
        }
    }
}
