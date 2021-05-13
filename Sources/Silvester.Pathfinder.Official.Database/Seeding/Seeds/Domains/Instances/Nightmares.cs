using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Domains.Instances
{
    public class Nightmares : Template
    {
        public static readonly Guid ID = Guid.Parse("9cc28967-eeee-4300-8723-a1fb61075bbc");

        protected override Domain GetDomain()
        {
            return new Domain 
            {
                Id = ID, 
                Name = "Nightmares", 
                Description = "You fill minds with horror and dread." 
            };
        }
    }
}
