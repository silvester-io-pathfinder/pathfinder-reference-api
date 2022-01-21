using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Domains.Instances
{
    public class Lightning : Template
    {
        public static readonly Guid ID = Guid.Parse("8ab289e9-baf0-407e-80af-280774a66c15");

        protected override Domain GetDomain()
        {
            return new Domain 
            {
                Id = ID, 
                Name = "Lightning", 
                Description = "You control electricity, thunder, and storms." 
            };
        }
    }
}
