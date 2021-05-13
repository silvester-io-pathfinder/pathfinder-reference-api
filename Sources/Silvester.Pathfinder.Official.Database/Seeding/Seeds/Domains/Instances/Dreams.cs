using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Domains.Instances
{
    public class Dreams : Template
    {
        public static readonly Guid ID = Guid.Parse("e214011e-7af3-4a53-9b4a-e0ed7ae4479a");

        protected override Domain GetDomain()
        {
            return new Domain 
            { 
                Id = ID, 
                Name = "Dreams", 
                Description = "You have the power to enter and manipulate dreams." 
            };
        }
    }
}
