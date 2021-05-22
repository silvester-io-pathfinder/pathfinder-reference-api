using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Bulks.Instances
{
    public class LightBulk : Template
    {
        public static readonly Guid ID = Guid.Parse("978d32f8-10b7-4150-bd9f-b8f037220542");

        protected override Bulk GetBulk()
        {
            return new Bulk 
            {
                Id = ID, 
                Name = "L", 
                BulkWeight = 0, 
                LightWeight = 1 
            };
        }
    }
}
