using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Domains.Instances
{
    public class Swarm : Template
    {
        public static readonly Guid ID = Guid.Parse("4c7d189c-915f-4c09-b711-fa65a68a34d7");

        protected override Domain GetDomain()
        {
            return new Domain 
            { 
                Id = ID, 
                Name = "Swarm", 
                Description = "You exert control over masses of creatures." 
            };
        }
    }
}
