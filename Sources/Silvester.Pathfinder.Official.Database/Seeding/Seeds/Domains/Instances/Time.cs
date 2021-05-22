using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Domains.Instances
{
    public class Time : Template
    {
        public static readonly Guid ID = Guid.Parse("3658060d-b09b-4e73-b949-0255b77bd07b");

        protected override Domain GetDomain()
        {
            return new Domain 
            { 
                Id = ID, 
                Name = "Time", 
                Description = "You reign over the flow of time." 
            };
        }
    }
}
