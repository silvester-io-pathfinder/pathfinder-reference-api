using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Domains.Instances
{
    public class Change : Template
    {
        public static readonly Guid ID = Guid.Parse("9c5f23af-1bf7-46c8-bdba-8067b03f752f");

        protected override Domain GetDomain()
        {
            return new Domain 
            {
                Id = ID, 
                Name = "Change", 
                Description = "You can restructure the physical and metaphysical." 
            };
        }
    }
}
