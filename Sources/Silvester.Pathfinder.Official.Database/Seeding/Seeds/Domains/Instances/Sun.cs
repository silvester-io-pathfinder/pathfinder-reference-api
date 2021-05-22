using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Domains.Instances
{
    public class Sun : Template
    {
        public static readonly Guid ID = Guid.Parse("d3a39e59-080b-4324-8921-124763c5b6af");

        protected override Domain GetDomain()
        {
            return new Domain 
            { 
                Id = ID, 
                Name = "Sun", 
                Description = "You harness the power of the sun and other light sources, and punish undead." 
            };
        }
    }
}
