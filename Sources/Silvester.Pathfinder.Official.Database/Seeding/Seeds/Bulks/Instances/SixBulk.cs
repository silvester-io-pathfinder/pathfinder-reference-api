using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Bulks.Instances
{
    public class SixBulk : Template
    {
        public static readonly Guid ID = Guid.Parse("3f86e7c2-2386-4a9a-90cb-f8a633257d24");
        
        protected override Bulk GetBulk()
        {
            return new Bulk
            {
                Id = ID, 
                Name = "6", 
                BulkWeight = 6, 
                LightWeight = 0 
            };
        }
    }
}
