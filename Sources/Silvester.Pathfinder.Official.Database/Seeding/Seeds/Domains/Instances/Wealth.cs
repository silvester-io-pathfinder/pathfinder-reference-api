using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Domains.Instances
{
    public class Wealth : Template
    {
        public static readonly Guid ID = Guid.Parse("794329a6-ca37-4ec4-b3bf-e979c639d628");

        protected override Domain GetDomain()
        {
            return new Domain 
            {
                Id = ID, 
                Name = "Wealth", 
                Description = "You hold power over wealth, trade, and treasure." 
            };
        }
    }
}
